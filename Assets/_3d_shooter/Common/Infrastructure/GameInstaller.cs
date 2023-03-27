using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private GameObject _playerPrefab;


    public override void InstallBindings()
    {
        Instantiate(_playerPrefab, _spawnPoint.position, Quaternion.identity);
    }
}
