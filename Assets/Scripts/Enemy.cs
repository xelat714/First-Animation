using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject _enemy;

    [SerializeField] Transform _enemyTransform;

    //[SerializeField] float _enemySpeed;

    [SerializeField] float _spawnTime, _currentTime;

    //[Range(1, 2)] float _minSpawnTime;
    //[Range(3, 4)] float _maxSpawnTime;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _spawnTime)
        {
            StartSpawn();
            ResetSpawn();
        }
    }

    void StartSpawn()
    {
        Instantiate(_enemy, _enemyTransform.position, _enemyTransform.rotation, _enemyTransform.transform);
        ResetSpawn();
    }

    void ResetSpawn()
    {
        _currentTime = 0;
        _spawnTime = Random.Range(1,10);
    }

}
