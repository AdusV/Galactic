using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDmg : MonoBehaviour
{
    public float thrust = 5f;
    [SerializeField] int damage = 5;
   
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, thrust , 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy") 
        {
            other.GetComponent<ChickenHp>().DamageToEnemyManager(damage);
            Destroy(this.gameObject);
        }
       
    }
}