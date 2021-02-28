using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatss : MonoBehaviour
{
    [SerializeField] int points = 1;
    [SerializeField] TextMeshProUGUI pointsText;
    // Dodanie widoku broni
    [SerializeField] TextMeshProUGUI greenText;
    public int greenPoints = 0;
    [SerializeField] Text yellowText;
    public int yellowPoints = 0;
   
    /// 
    public static PlayerStatss Instance = null;
    
    private void Awake()
    {
        if(Instance !=null && Instance!=this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }
    /// 
    public int Points
    {
        get { return points; }
        set { points = value; }
    }
    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        UpdatePointsTextUI();
    }
    public void UpdatePointsTextUI()
    {
        pointsText.text = points.ToString();
    }
    public int greenWeapon
    {
        get { return greenPoints; }
        set { greenPoints = value; }
    }
    public void addGreenWeapon(int greenPointsToAdd)
    {
        greenPoints += greenPointsToAdd;
        UpdatePointsGreenWeaponTextUI();
    }
    public void UpdatePointsGreenWeaponTextUI()
    {
        greenText.text = greenPoints.ToString();
    }
    public int yellowWeapon
    {
        get { return yellowPoints; }
        set { yellowPoints = value; }
    }
    public void addYellowWeapon(int yellowPointsToAdd)
    {
        yellowPoints += yellowPointsToAdd;
        UpdatePointsYellwoWeaponTextUI();
    }
    public void UpdatePointsYellwoWeaponTextUI()
    {
        yellowText.text = yellowPoints.ToString();
    }
}
