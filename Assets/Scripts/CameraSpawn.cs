using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
using Math = System.Math;

public class CameraSpawn : MonoBehaviour
{
    public GameObject ball; 
    
    
    private void Start()
    {
        InvokeRepeating("Spawn", 1, 5);
    }
    public void Spawn()
    {
        var camera = Camera.main;
        var angle = camera.fieldOfView;
        
        var width = camera.pixelWidth / 2;
        var height = camera.pixelHeight / 2;

        var sum = width + height;

        var c = (double)width / sum;
        var xx = c * 1.5708;
        var w = Math.Tan(xx) * 8;
        
        
        var cc = (double)height / sum;
        var x = cc * 1.5708;
        var h = Math.Tan(x) * 8;
        
        
        Debug.Log(h);
        Debug.Log(w);
        
        
        

            



        Instantiate(ball, camera.transform.position, Quaternion.identity);
    }
}
