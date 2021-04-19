using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MisslieDestroyer : MonoBehaviour
{
     public float thrust = 5f;
    //[SerializeField] int damage = 5;

    public Vector3 Direction;
    public GameObject[] enemies;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(Direction);
    }
    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        StartCoroutine("MissleDestoryAll");
    }
    IEnumerator MissleDestoryAll()
    {
        yield return new WaitForSeconds(3);
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        
    }

}
