using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public Manager manager;
    private void Start()
    {
        manager.ourBase = transform;
    }
}
