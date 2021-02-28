using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShipFire : MonoBehaviour
{


    /// 
    public static StarShipFire Instance = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }
    ///
    //
    public GameObject[] gunlist = new GameObject[5];
    bool[] guns = new bool[] { false, true, false, false, false, false };
    private KeyCode[] keys = new KeyCode[] { KeyCode.Alpha0, KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4 };
    private int maxGuns = 1;

    public void addGun(int number)
    {
        guns[number] = true;
        maxGuns++;
    }
    private void Update()
    {
        for(int i=0;i<keys.Length;i++)
        {
            if(Input.GetKeyDown(keys[i])&&guns[i])
            {
                hideGuns();
                gunlist[i].SetActive(true);
            }
        }

    }
    private void hideGuns()
    {
        for (int i = 1; i < maxGuns + 1; i++)
        {
            gunlist[i].SetActive(false);
        }
    }



    }
