using UnityEngine;

public class Candy : MonoBehaviour
{
    public CandyColor _color { get; private set; }

    public void Inicilize(in CandyColor color)
    {
        _color = color;
        gameObject.SetActive(false);
    }

    public void Init(in Vector3 cellPosition)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = cellPosition;
    }
}