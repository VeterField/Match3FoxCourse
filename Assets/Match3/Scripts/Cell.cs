using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Cell : MonoBehaviour
{
    [SerializeField] private CellRole _role;
    [SerializeField] private int _candyColorId;

    [SerializeField] private Cell _upperCandyColor;
    [SerializeField] private Cell _bottomCandyColor;
    [SerializeField] private Cell _rightCandyColor;
    [SerializeField] private Cell _leftCandyColor;

    private CandyPool _candyPool;

    private readonly float _lenthBetwenCells = 1.5f;

    public void Inicilize(in int Xorder, in int Yorder, in CellRole role, in CandyPool candyPool)
    {
        gameObject.transform.position = new Vector3(Xorder * _lenthBetwenCells, Yorder * _lenthBetwenCells, 0);
        _role = role;
        _candyPool = candyPool;
    }

    public void SetNearCells(in Cell upper, in Cell right, in Cell bottom, in Cell left)
    {
        _upperCandyColor = upper;
        _rightCandyColor = right;
        _bottomCandyColor = bottom;
        _leftCandyColor = left;
    }

    public void TryAddCandyToField()
    {
        if (_role == CellRole.Spawn & _candyColorId == 0)
        {
            StartCoroutine(AddCandyToField());
        }
    }

    private IEnumerator AddCandyToField()
    {
        Candy record = _candyPool.GetCandy();
        if (record != null)
        {
            record.Init(gameObject.transform.position);
        }
        else
        {
            yield return new WaitForSeconds(1);
            AddCandyToField();
        }
    }
}