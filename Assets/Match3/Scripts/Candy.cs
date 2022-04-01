using UnityEngine;

public class Candy : MonoBehaviour
{
    public int _colorId { get; private set; }

    public void Inicilize(in int colorId)
    {
        _colorId = colorId;
        gameObject.SetActive(false);
    }

    public void Init(in Vector3 cellPosition)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = cellPosition;
    }
}