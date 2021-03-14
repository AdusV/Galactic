using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponShip : MonoBehaviour
{
    public GameObject defaultWeapon;
    public List<GameObject> prefubWeapons = new List<GameObject>();
    private GameObject clone;

    //
    public GameObject currentWeapon;


    public Dictionary<string, GameObject> weapons = new Dictionary<string, GameObject>();
 
    int weaponNumber = 1;
    
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
    }

    public void SetDefaultWeapon()
    {
        currentWeapon = defaultWeapon;
        foreach (var weapon in weapons.Where(x => x.Value.tag != defaultWeapon.tag))
        {
            Destroy(weapon.Value);
        }

        weapons.Clear();
        weapons.Add(defaultWeapon.tag, defaultWeapon);
    }

    internal void AddWeapon(string tag)
    {
        if (!weapons.TryGetValue(tag, out var newWapon))
        {
            var weaponPrefab = prefubWeapons.FirstOrDefault(x => x.tag == tag);
            if (weaponPrefab == null)
            {
                throw new Exception("Brak rodzaju broni w deklarowanych prefabach");
            }

            newWapon = weaponPrefab;
            weapons.Add(tag, newWapon);
        }
        currentWeapon = newWapon;
    }
}
