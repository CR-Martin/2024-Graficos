using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPointsObstaclesList;
    [SerializeField] private GameObject obstaclePrefab;

    public static Action OnObstacleDestroy;

    private void OnEnable()
    {
        OnObstacleDestroy += SpawnObstacle;
    }
    void Start()
    {
        SpawnObstacle();
    }
    private void OnDisable()
    {
        OnObstacleDestroy -= SpawnObstacle;
    }

    private void SpawnObstacle()
    {
        int randomPosition = UnityEngine.Random.Range(0, spawnPointsObstaclesList.Length);
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPointsObstaclesList[randomPosition].position, Quaternion.identity);
    }
    //private void StartRespawnObstacle()
    //{
    //    Invoke(nameof(SpawnObstacle), obstacleSpawnInterval);
    //}

}
