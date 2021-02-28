using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenHp : MonoBehaviour
{
    [SerializeField] int hp = 10;
    public void DamageToEnemyManager(int dmg)
    {
        hp -= dmg;
        if (hp <= 0) 
        {
            Destroy(this.gameObject);
        }
    }
}
