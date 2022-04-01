using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabric : MonoBehaviour
{
    [SerializeField] private Cell _cellPrefab;
    [SerializeField] private Candy _blueCandy;
    [SerializeField] private Candy _greenCandy;
    [SerializeField] private Candy _orangeCandy;
    [SerializeField] private Candy _purpleCandy;
    [SerializeField] private Candy _redCandy;

    public Cell GetCell()
    {
        return Instantiate(_cellPrefab);
    }

    public Candy GetCandy(in CandyColor color)
    {
        if (color == CandyColor.Blue)
        {
            return Instantiate(_blueCandy);
        }
        else if (color == CandyColor.Green)
        {
            return Instantiate(_greenCandy);
        }
        else if (color == CandyColor.Orange)
        {
            return Instantiate(_orangeCandy);
        }
        else if (color == CandyColor.Purple)
        {
            return Instantiate(_purpleCandy);
        }
        else if(color == CandyColor.Red)
        {
            return Instantiate(_redCandy);
        }
        else
        {
            return null;
        }
    }
}