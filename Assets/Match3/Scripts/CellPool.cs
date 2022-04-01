using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPool : MonoBehaviour
{
    private List<Cell> _gameCells;
    public List<Cell> _spawnCells;

    private int _fieldWidth;
    private int _fieldHeight;

    public void InitGameField(in int width, in int height, in Fabric fabric, in CandyPool candyPool)
    {
        _gameCells = new List<Cell>();
        _spawnCells = new List<Cell>();

        _fieldWidth = width;
        _fieldHeight = height;

        SetGameField(fabric, candyPool);
        SetCellNeigbours();
    }

    private void SetGameField(in Fabric fabric, in CandyPool candyPool)
    {
        for (int y = 0; y < _fieldHeight; y++)
        {
            for (int x = 0; x < _fieldWidth; x++)
            {
                Cell record = fabric.GetCell();

                if (y == _fieldHeight - 1)
                {
                    record.Inicilize(x, y, CellRole.Spawn, candyPool);
                    _spawnCells.Add(record);
                }
                else
                {
                    record.Inicilize(x, y, CellRole.Game, candyPool);
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

    public void InitFirstWave()
    {
        for (int i = 0; i < _spawnCells.Count; i++)
        {
            _spawnCells[i].TryAddCandyToField();
        }
    }
}