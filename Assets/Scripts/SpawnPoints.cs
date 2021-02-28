using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject sprite;
    GameObject clone;
    float repeatSprite = 3;
    private void Start()
    {
        InvokeRepeating("spawnSprite", 1, repeatSprite);
    }
    void spawnSprite()
    {
        clone = Instantiate(sprite, new Vector3(Random.Range(-15, 15), Random.Range(10, 3), -2), Quaternion.identity);
    }
}
