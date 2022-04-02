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

    public Candy GetCandy(in int colorId)
    {
        if (colorId == 1)
        {
            return Instantiate(_blueCandy);
        }
        else if (colorId == 2)
        {
            return Instantiate(_greenCandy);
        }
        else if (colorId == 3)
        {
            return Instantiate(_orangeCandy);
        }
        else if (colorId == 4)
        {
            return Instantiate(_purpleCandy);
        }
        else if (colorId == 5)
        {
            return Instantiate(_redCandy);
        }
        else
        {
            return null;
        }
    }
}