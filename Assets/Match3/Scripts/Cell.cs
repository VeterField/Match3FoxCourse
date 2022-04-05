using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Cell : MonoBehaviour
{
    [SerializeField] private CellRole _role;
    [SerializeField] private Candy _candyInCell;

    [SerializeField] private Cell _upperCandyColor;
    [SerializeField] private Cell _bottomCandyColor;
    [SerializeField] private Cell _rightCandyColor;
    [SerializeField] private Cell _leftCandyColor;

    private Fabric _fabric;

    private readonly float _lenthBetwenCells = 1.5f;

    public void Inicilize(in int Xorder, in int Yorder, in CellRole role, in Fabric fabric)
    {
        gameObject.transform.position = new Vector3(Xorder * _lenthBetwenCells, Yorder * _lenthBetwenCells, 0);
        _role = role;
        _fabric = fabric;
    }

    public void SetNearCells(in Cell upper, in Cell right, in Cell bottom, in Cell left)
    {
        _upperCandyColor = upper;
        _rightCandyColor = right;
        _bottomCandyColor = bottom;
        _leftCandyColor = left;
    }

    public void SetCandy()
    {
        Candy candy = _fabric.GetAnyCandy();
        candy.Init(gameObject.transform.position);
        _candyInCell = candy;
    }

    public void GetCandy()
    {
        _candyInCell.End();
        _candyInCell = null;
    }
}