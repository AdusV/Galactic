using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext : MonoBehaviour
{
    public string newLevelName;
    private void Update()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.All(x => x.activeSelf == false))
        {
            SceneManager.LoadScene(newLevelName);
        }
    }

        public void FindEnemy()
    {
        
    }
}
