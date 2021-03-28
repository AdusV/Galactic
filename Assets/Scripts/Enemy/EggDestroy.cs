using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggDestroy : MonoBehaviour
{
    [SerializeField] int live;
    public GameObject Player;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            PlayerMenager menager = other.GetComponent<PlayerMenager>();

            if (menager.isProtect)
                return;

            LivesCounterScript.Instance.loseLife();
            Destroy(other.gameObject);
            Instantiate(Player, new Vector3(0, -5, -2), Quaternion.Euler(90,180,0));
        }
        
    }
}
