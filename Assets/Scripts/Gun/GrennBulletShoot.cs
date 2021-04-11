using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class GrennBulletShoot : Shoot
{
    public override void _Shoot(Transform trans)
    {
        for (int i = 0; i < Level; i++)
        {
            var clone = Instantiate(this.gameObject, trans.position, Quaternion.identity);
            var bulletDmg = clone.GetComponent<BulletDmg>();
            bulletDmg.Direction = b[i] * thrust;
        }
    }

    private Dictionary<int, Vector3> b = new Dictionary<int, Vector3>()
    {
        {0, new Vector3(0, 1, 0)},
        {1, new Vector3(-0.25f, 1, 0)},
        {2, new Vector3(0.25f, 1, 0)},
        {3, new Vector3(-0.35f, 1, 0)},
        {4, new Vector3(0.35f, 1, 0)},
    };
}
