using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHp : MonoBehaviour
{
    [SerializeField] int hp = 100;
    public void DamageToEnemyManager(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
