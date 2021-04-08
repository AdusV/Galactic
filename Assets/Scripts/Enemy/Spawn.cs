using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject chicken;
    private GameObject clone;

    
    int enemyCount = 0;
    public float maxEnemyCount = 20;
    public float timeBetweenSpawns = .1f;
    

   

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, timeBetweenSpawns);
    }



    public void SpawnEnemy()
    {

        clone = Instantiate(chicken, transform.position, Quaternion.Euler(0, 180, 0));
        enemyCount++;
        if (enemyCount >= maxEnemyCount)
        {
            CancelInvoke("SpawnEnemy");
        }

    }
}
