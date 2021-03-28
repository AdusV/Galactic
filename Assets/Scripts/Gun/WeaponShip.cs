using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponShip : MonoBehaviour
{
    public List<GameObject> prefubWeapons = new List<GameObject>();
    private GameObject clone;

    //
    public GameObject currentWeapon;
    private int currentWeaponId;

    public List<GameObject> weapons = new List<GameObject>();
 
    
    void Start()
    {
        SetDefaultWeapon();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clone = Instantiate(currentWeapon, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentWeaponId  = (currentWeaponId == 0) ? weapons.Count() - 1 : currentWeaponId - 1;
            currentWeapon = weapons[currentWeaponId];
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            currentWeaponId = (currentWeaponId == weapons.Count() - 1) ? 0 : currentWeaponId + 1;
            currentWeapon = weapons[currentWeaponId];
        }
    }

    public void SetDefaultWeapon()
    {
        currentWeapon = prefubWeapons.First();
        currentWeaponId = 0;
        weapons.Clear();
        weapons.Add(prefubWeapons.First());
    }

    internal void AddWeapon(string tag)
    {
        var weapon = weapons.FirstOrDefault(x => x.tag == tag);
        if (weapon == null)
        {
            Debug.Log("test");
            var weaponPrefab = prefubWeapons.FirstOrDefault(x => x.tag == tag);
            if (weaponPrefab == null)
            {
                throw new Exception("Brak rodzaju broni w deklarowanych prefabach");
            }

            weapon = weaponPrefab;
            weapons.Add(weapon);
        }
        currentWeapon = weapon;
    }
}
