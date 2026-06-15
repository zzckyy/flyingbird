using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public float spawnRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", spawnRate, spawnRate);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-1f, 1f);
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
