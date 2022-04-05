using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabric : MonoBehaviour
{
    [SerializeField] private Cell _cellPrefab;
    [SerializeField] private List<Candy> _candies;

    public Cell GetCell()
    {
        return Instantiate(_cellPrefab);
    }

    public Candy GetCandyById(in int colorId)
    {
        if (colorId < _candies.Count)
        {
            return GetCandy(colorId);
        }
        else
        {
            return null;
        }
    }
    
    public Candy GetAnyCandy()
    {
        int number = Random.Range(0, _candies.Count);

        return GetCandy(number);
    }

    private Candy GetCandy(in int colorId)
    {
        Candy record = Instantiate(_candies[colorId]);
        record.Inicilize(colorId);
        return record;
    }
}