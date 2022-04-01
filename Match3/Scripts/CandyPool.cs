using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyPool : MonoBehaviour
{
    private List<Candy> _candies;

    public void SetStartCandies(in Fabric fabric)
    {
        _candies = new List<Candy>();

        GetCandies(20, CandyColor.Blue, fabric);
        GetCandies(20, CandyColor.Green, fabric);
        GetCandies(20, CandyColor.Orange, fabric);
        GetCandies(20, CandyColor.Purple, fabric);
        GetCandies(20, CandyColor.Red, fabric);
    }

    private void GetCandies(in int amount, in CandyColor color, in Fabric fabric)
    {
        if (amount > 0)
        {
            for (int i = 0; i < amount; i++)
            {
                Candy record = fabric.GetCandy(color);
                _candies.Add(record);
                record.Inicilize(color);
            }
        }
    }

    public Candy GetCandy()
    {
        int randomNumber = Random.Range(1, 5);

        if (randomNumber == 1)
        {
            return GetCandyWithColor(CandyColor.Blue);
        }
        else if (randomNumber == 2)
        {
            return GetCandyWithColor(CandyColor.Green);
        }
        else if (randomNumber == 3)
        {
            return GetCandyWithColor(CandyColor.Orange);
        }
        else if (randomNumber == 4)
        {
            return GetCandyWithColor(CandyColor.Purple);
        }
        else if (randomNumber == 5)
        {
            return GetCandyWithColor(CandyColor.Red);
        }
        else
        {
            return null;
        }
    }

    private Candy GetCandyWithColor(in CandyColor color)
    {
        for (int i = 0; i < _candies.Count; i++)
        {
            if (_candies[i]._color == color & _candies[i].isActiveAndEnabled == false)
            {
                return _candies[i];
            }
        }

        return null;
    }
}