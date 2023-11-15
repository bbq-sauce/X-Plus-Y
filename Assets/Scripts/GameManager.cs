using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int a, b;
    [SerializeField] TMP_Text topNumberText;
    [SerializeField] TMP_Text scoreText;
    public static GameManager instance;
    public SceneController sceneController;
    //public NumberCell numberCell;
    public int gridSize = 9;
    
    public int score;
    

    public float totalTime = 120f; // Total time in seconds (2 minutes)
    private float currentTime;
    [SerializeField] TMP_Text timerText;

   
    public int topNumber;

    public int clickCount = 0;
    void Start()
    {
        
        SetTopNUmber();
       
        instance = this;
        
        // Start the game timer
        currentTime = totalTime;
        UpdateTimerText();
    }

   

    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            SceneManager.LoadScene(2);
           
        }
    }

    public void CalculateSum(int a,int b)
    {

        int Sum = a+b;
        int top = ReturnTopNumber();
        
        
        if(Sum == top)
        {
            score++;
            
            
        }
        else
        {
            score--;
            
        }

        scoreText.text = score.ToString();
        Analytics.instance.NumberPairs(a,b);
    }

    

    
    void UpdateTimerText()
    {

        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

   

    public void SetTopNUmber()
    {
        topNumber =Random.Range(2, 19);
        
        topNumberText.text =  topNumber.ToString();
        
    }

    int ReturnTopNumber()
    {
        return topNumber;
    }

    
}
