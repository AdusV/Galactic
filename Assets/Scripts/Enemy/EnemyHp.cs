using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    [SerializeField] int hp = 10;
    public Manager manager;
    //public GameObject particlePrefab;
    public GameObject particle;
    private void Awake()
    {
        manager = GameObject.FindObjectOfType<Manager>();
        if(manager == null)
        {
            Debug.LogError("blad");
        }
        
    }
    public void DamageToEnemyManager(int dmg)
    {
        hp -= dmg;
        if (hp > 0) return;
        
        
        if (particle != null)
        {
            Instantiate(particle, transform.position, transform.rotation);
        }
        Destroy(this.gameObject);
    }
}
