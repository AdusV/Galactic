using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shoot : MonoBehaviour
{
    private void Start()
    {
        Level = 1;
    }

    public float thrust = 5f;
    public int Level = 1;
    public abstract void _Shoot(Transform trans);
}
