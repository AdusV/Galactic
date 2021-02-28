using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWeapon : MonoBehaviour
{
    [SerializeField] int yellowWeaponPoints;
    [SerializeField] int greenbackPoints = -1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStatss.Instance.addYellowWeapon(yellowWeaponPoints);
            PlayerStatss.Instance.addGreenWeapon(greenbackPoints);
            Destroy(this.gameObject);
        }
        
    }
}
