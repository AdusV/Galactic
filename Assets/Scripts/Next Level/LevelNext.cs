using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelNext : MonoBehaviour
{
    void Start()
    {
        


    }
    private void Update()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.All(x => x.activeSelf == false))
        {
            Application.LoadLevel(1);
        }
    }

        public void FindEnemy()
    {
        
    }
}
