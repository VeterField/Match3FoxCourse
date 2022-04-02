using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyPool : MonoBehaviour
{
    private List<Candy> _candies;
    private Fabric _fabric;

    public void Init(in Fabric fabric)
    {
        _candies = new List<Candy>();

        _fabric = fabric;
    }

    public Candy GetCandy()
    {
        int randomNumber = Random.Range(1, 5);

        return GetCandyWithColor(randomNumber);
    }

    private Candy GetCandyWithColor(in int colorId)
    {
        for (int i = 0; i < _candies.Count; i++)
        {
            if (_candies[i]._colorId == colorId & _candies[i].isActiveAndEnabled == false)
            {
                return _candies[i];
            }
        }

        return _fabric.GetCandy(colorId);
    }
}