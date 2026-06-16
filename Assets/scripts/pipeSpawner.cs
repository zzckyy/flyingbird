using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public float spawnRate = 2f;

    public float minY = 1f;
    public float maxY = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", spawnRate, spawnRate);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
