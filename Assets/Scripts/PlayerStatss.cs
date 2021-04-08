using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatss : MonoBehaviour
{
    [SerializeField] int points = 1;
    [SerializeField] TextMeshProUGUI pointsText;
  
   
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

}
