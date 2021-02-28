using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenWeapon : MonoBehaviour
{
    
    [SerializeField] int greenPoints;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerStatss.Instance.addGreenWeapon(greenPoints);

            Destroy(this.gameObject);
        }
      
    }
}
