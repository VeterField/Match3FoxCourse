using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellOperator : MonoBehaviour
{
    private List<Cell> _gameCells;
    private List<Cell> _spawnCells;

    private int _fieldWidth;
    private int _fieldHeight;

    public void InitGameField(in int width, in int height, in Fabric fabric)
    {
        _gameCells = new List<Cell>();
        _spawnCells = new List<Cell>();

        _fieldWidth = width;
        _fieldHeight = height;

        SetGameField(fabric);
        SetCellNeigbours();
    }

    private void SetGameField(in Fabric fabric)
    {
        for (int y = 0; y < _fieldHeight; y++)
        {
            for (int x = 0; x < _fieldWidth; x++)
            {
                Cell record = fabric.GetCell();

                if (y == _fieldHeight - 1)
                {
                    record.Inicilize(x, y, CellRole.Spawn, fabric);
                    _spawnCells.Add(record);
                }
                else
                {
                    record.Inicilize(x, y, CellRole.Game, fabric);
                }
                _gameCells.Add(record);
            }
        }
    }

    private void SetCellNeigbours()
    {
        for (int i = 0; i < _gameCells.Count; i++)
        {
            _gameCells[i].SetNearCells(SetUpperCell(i), null, SetBottomCell(i), null);
        }
    }

    private Cell SetUpperCell(in int number)
    {
        if (number < (_fieldHeight * _fieldWidth - _fieldWidth))
        {
            return _gameCells[number + _fieldWidth];
        }
        else
        {
            return null;
        }
    }

    private Cell SetBottomCell(in int number)
    {
        if (number >= (_fieldWidth))
        {
            return _gameCells[number - _fieldWidth];
        }
        else
        {
            return null;
        }
    }

    public void SetFirstWave()
    {
        for (int i = 0; i < _spawnCells.Count; i++)
        {
            _spawnCells[i].SetCandy();
        }
    }
}