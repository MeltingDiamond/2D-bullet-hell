using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public List<Transform> spawnPoints;

    public float minSpawnDelay = 0.5f;
    public float maxSpawnDelay = 2.5f;

    public float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= 1 * Time.deltaTime;
        }
        else
        {
            int randomSpawn = Random.Range(0, spawnPoints.Count);
            
            Instantiate(enemy, spawnPoints[randomSpawn].position, Quaternion.identity);
            
            timer = Random.Range(minSpawnDelay, maxSpawnDelay);
        }
    }
}
