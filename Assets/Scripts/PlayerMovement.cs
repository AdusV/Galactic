using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //horizontal - poziomy
    
    float h;
    public float horizontalSpeed = 2.0f;
    private void Update()
    {
        h = Input.GetAxis("Mouse X") * horizontalSpeed;
        transform.Translate(-h, 0, 0);
        if(Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
