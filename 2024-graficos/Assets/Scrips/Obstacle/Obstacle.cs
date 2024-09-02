using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float minimunTimeRange = 1;
    [SerializeField] private float maximumTimeRange = 1;
    private float timeBeforeDestruction;

    void Start()
    {
        timeBeforeDestruction = Random.Range(minimunTimeRange, maximumTimeRange);
        Debug.Log(timeBeforeDestruction);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SelfDestruct());

    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(timeBeforeDestruction);
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        ObstacleSpawner.OnObstacleDestroy?.Invoke();

        Debug.Log("It works");
    }
}
