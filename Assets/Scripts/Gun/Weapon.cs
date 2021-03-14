using UnityEngine;

public class Weapon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var weaponShip = other.GetComponent<WeaponShip>();
            weaponShip.AddWeapon(gameObject.tag);

            Destroy(this.gameObject);
        }
    }
}
