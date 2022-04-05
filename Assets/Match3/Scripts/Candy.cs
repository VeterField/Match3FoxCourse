using UnityEngine;

public class Candy : MonoBehaviour
{
    public int _colorId { get; private set; }

    public void Inicilize(in int colorId)
    {
        _colorId = colorId;
    }

    public void Init(in Vector3 cellPosition)
    {
        gameObject.transform.position = cellPosition;
    }

    public void End()
    {
        Object.Destroy(this);
    }
}