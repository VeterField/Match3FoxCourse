using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private Fabric _fabric;
    [SerializeField] private CellOperator _cellOperator;

    private static readonly int _gameFieldWidth = 5;
    private static readonly int _gameFieldHeight = 6;

    private void Start()
    {
        _cellOperator.InitGameField(_gameFieldWidth, _gameFieldHeight, _fabric);
        _cellOperator.SetFirstWave();
    }
}