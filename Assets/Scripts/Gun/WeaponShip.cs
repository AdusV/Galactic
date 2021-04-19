using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class WeaponShip : MonoBehaviour
{
    public List<GameObject> prefabWeapons = new List<GameObject>();

    //
    public GameObject currentWeapon;
    private int currentWeaponId;

    public List<GameObject> weapons = new List<GameObject>();
    //
    public GameObject missileWeapon;
    private GameObject clone;
 
    
    void Start()
    {
        SetDefaultWeapon();
        foreach (var prefabWeapon in prefabWeapons)
        {
            var shoot = prefabWeapon.GetComponent<Shoot>();
            shoot.Level = 1;
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var shoot = currentWeapon.GetComponent<Shoot>();
            shoot._Shoot(this.transform);
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            clone =Instantiate(missileWeapon, transform.position, Quaternion.identity);
        }

    }

    public void SetDefaultWeapon()
    {
        currentWeapon = prefabWeapons.First();
        currentWeaponId = 0;
        weapons.Clear();
        weapons.Add(prefabWeapons.First());
    }

    internal void AddWeapon(string tag)
    {
        var weapon = weapons.FirstOrDefault(x => x.tag == tag);
        if (weapon == null)
        {
            Debug.Log("test");
            var weaponPrefab = prefabWeapons.FirstOrDefault(x => x.tag == tag);
            if (weaponPrefab == null)
            {
                throw new Exception("Brak rodzaju broni w deklarowanych prefabach");
            }

            weapon = weaponPrefab;
            weapons.Add(weapon);
        }
        else
        {
            var shoot = weapon.GetComponent<Shoot>();
            if (shoot.Level < 6)
            {
                shoot.Level++;
            }
        }
        currentWeapon = weapon;
    }
}
