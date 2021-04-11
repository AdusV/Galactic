using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext : MonoBehaviour
{
    public string newLevelName;
    
    public GameObject boss;
    private bool respawnBoss = false;
    private GameObject clone;
    private void Update()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.All(x => x.activeSelf == false))
        {
            if (boss != null && !respawnBoss)
            {
                clone = Instantiate(boss, new Vector3(Random.Range(-15, 16), Random.Range(8, 5), -2), Quaternion.Euler(0, 180, 0));
                respawnBoss = true;
            }
            else
            {
                respawnBoss = false;
                SceneManager.LoadScene(newLevelName);
            }
        }
        

    }

    
    
   
}
