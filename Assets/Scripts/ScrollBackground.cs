using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollspeed = 0.2f;
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void Update()
    {
        float offset = Time.time * scrollspeed;
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}
