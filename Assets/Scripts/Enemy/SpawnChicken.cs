using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnChicken : MonoBehaviour
{
    public GameObject chicken;
    private GameObject clone;
   
    //
    int enemyCount = 0;
    public float maxEnemyCount = 20;
    public float timeBetweenSpawns = .1f;
  

    private void Awake()
    {
        InvokeRepeating("Spawn", 0, timeBetweenSpawns);
    }
  


    public void Spawn()
    {
    
        clone = Instantiate(chicken, new Vector3(Random.Range(-15, 16), Random.Range(8, 5), -2), Quaternion.Euler(0, 180, 0));
        enemyCount++;
        if (enemyCount>=maxEnemyCount)
        {
            CancelInvoke("Spawn");
        }
       
    }
   


}
