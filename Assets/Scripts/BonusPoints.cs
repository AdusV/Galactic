using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoints : MonoBehaviour
{
    [SerializeField] int points;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerStatss.Instance.AddPoints(points);
            Destroy(this.gameObject);
        }
       
    }
}
