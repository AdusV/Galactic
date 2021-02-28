using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesCounterScript : MonoBehaviour
{
  
    Text uiText;
    public int maxLives;
    int lives;
    public static LivesCounterScript Instance = null;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }
    private void Start()
    {
        lives = maxLives;
        uiText = this.GetComponent<Text>();
        updateLivesCounter();
    }
    public bool addLife()
    {
        if(lives<=maxLives)
        {
            lives++;
            updateLivesCounter();
            return true;
        }
        return false;
    }
    public bool loseLife()
    {
        lives--;
        if (lives > 0)
        {
            updateLivesCounter();
            return false;
        }
        lives = 0;
        updateLivesCounter();
        return true;
    }
    void updateLivesCounter()
    {
        uiText.text = "<color=red>Lives</color>: " + lives;
    }
}
