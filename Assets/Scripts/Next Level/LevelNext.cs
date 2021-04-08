using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext : MonoBehaviour
{
    public string newLevelName;
   

    public GameObject boss;
    private GameObject clone;
    private void Update()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.All(x => x.activeSelf == false))
        {
            //clone = Instantiate(boss, new Vector3(Random.Range(-15, 16), Random.Range(8, 5), -2), Quaternion.Euler(0, 180, 0));
            SceneManager.LoadScene(newLevelName);
        }
        

    }

    
    
   
}
