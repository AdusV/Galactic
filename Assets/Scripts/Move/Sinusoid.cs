using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinusoid : MonoBehaviour
{
    public Camera Camera;
    public float angle = 1; 
    private int _amplitude;

    // Start is called before the first frame update
    void Start()
    {
        _amplitude = 8;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        var forward = new Vector3(_amplitude * Mathf.Sin(pos.y), angle, 0);
        Debug.Log(forward.x);
        transform.Translate(forward * Time.deltaTime);
    }
}
