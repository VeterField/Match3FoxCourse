using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private Fabric _fabric;

    [SerializeField] private CellPool _cellPool;
    [SerializeField] private CandyPool _candyPool;

    private static readonly int _gameFieldWidth = 5;
    private static readonly int _gameFieldHeight = 6;

    private void Start()
    {
        _cellPool.InitGameField(_gameFieldWidth, _gameFieldHeight, _fabric, _candyPool);
        _candyPool.Init(_fabric);
        _cellPool.InitFirstWave();
    }
}