using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShip : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet1;
    private GameObject clone;
    //
    public GameObject yellowbullet;
    //  
    int weaponNumber = 1;
    private void Update()
    {

        switch (weaponNumber)
        {
            case 1:
                if (Input.GetButtonDown("Fire1"))
                {
                    clone = Instantiate(bullet, transform.position, Quaternion.identity);
                    if (PlayerStatss.Instance.greenPoints >= 1)
                    {
                        clone = Instantiate(bullet1, transform.position, Quaternion.identity);
                    }
                    else if (PlayerStatss.Instance.yellowPoints >= 1)
                    {
                        clone = Instantiate(yellowbullet, transform.position, Quaternion.identity);
                    }


                }
                break;
            case 2:
                if (PlayerStatss.Instance.yellowPoints >= 1)
                {
                    if (Input.GetButtonDown("Fire1"))
                    {
                        clone = Instantiate(bullet, transform.position, Quaternion.identity);
                        clone = Instantiate(yellowbullet, transform.position, Quaternion.identity);
                    }

                }
                break;
            default:
                Debug.Log("powrot");
                break;
        }
        

    }
}
