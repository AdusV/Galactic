using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDmg : MonoBehaviour
{
    // public float thrust = 5f;
    [SerializeField] int damage = 5;

    public Vector3 Direction;
   
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        rb.AddForce(Direction);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) 
        {
            other.GetComponent<EnemyHp>().DamageToEnemyManager(damage);
            
            Destroy(this.gameObject);
        }
       
    }
}