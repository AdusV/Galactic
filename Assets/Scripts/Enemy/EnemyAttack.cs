using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject egg;
    private GameObject cloneEgg;
    public float spawnThreshold = 100;
    public float spawnDecrement = .1f;
    private void Update()
    {

        if (Random.Range(0, spawnThreshold) <= .5)
        {
            cloneEgg = Instantiate(egg, transform.position, Quaternion.identity);
            spawnThreshold -= spawnDecrement;
        }
        if (spawnThreshold < 2)
        {
            spawnThreshold = 2;
        }
    }
}
