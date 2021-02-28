using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPointsGun : MonoBehaviour
{
    public GameObject yellowWeapon;
    public GameObject greenWeapon;
    private GameObject clone;
    public float timeBetweenSpawnGreen;
    public float timeBetweenSpawnYellow;
    public float maxSpawn = 1;
    private void Start()
    {
        InvokeRepeating("SpawnWeaponYellow", Random.Range(2,10), timeBetweenSpawnYellow);
        InvokeRepeating("SpawnWeaponGreen", Random.Range(2, 10), timeBetweenSpawnGreen);


    }
    private void SpawnWeaponYellow()
    {
        clone = Instantiate(yellowWeapon, new Vector3(Random.Range(-10, 10), Random.Range(3, 10), -2),Quaternion.identity);

    }
    private void SpawnWeaponGreen()
    {
        clone = Instantiate(greenWeapon, new Vector3(Random.Range(-10, 10), Random.Range(3, 10), -2), Quaternion.identity);

    }
}
