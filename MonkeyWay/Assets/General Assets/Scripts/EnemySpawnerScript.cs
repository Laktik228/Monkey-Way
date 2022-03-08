using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public float spawnRange = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range((transform.position.x - spawnRange),(transform.position.x + spawnRange) );
            whereToSpawn = new Vector2 (randX, transform.position.y);
            Instantiate (enemy, whereToSpawn, Quaternion.identity);
        }
        
        
    }
}
