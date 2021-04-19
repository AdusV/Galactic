using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpawn : MonoBehaviour
{
    public GameObject ball;
    
    private void Start()
    {
        InvokeRepeating("Spawn", 1, 5);
    }
    public void Spawn()
    {
        var camera = Camera.main.transform;
        Instantiate(ball, camera.position, Quaternion.identity);
    }
}
