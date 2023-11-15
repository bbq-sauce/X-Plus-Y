using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CellButtonFunction : MonoBehaviour
{
    public static CellButtonFunction Instance;
    public int startNo;
    public int endNo;
   
    
    void Start()
    {
       
        Button button = GetComponentInChildren<Button>();
        button.onClick.AddListener(() => ClickHandler(button));
    }

    void ClickHandler(Button button)
    {
        TMP_Text buttonNumber = button.GetComponentInChildren<TMP_Text>();
  

        if (buttonNumber == null)
        {
            Debug.LogError("TMP_Text component not found on the button.");
            return;
        }

        int currentNumber = int.Parse(buttonNumber.text);

        if (GameManager.instance.clickCount==0)
        {

            startNo = currentNumber;
            GameManager.instance.a = startNo;
            Debug.Log("Start Number: " + startNo);
            //isStartButtonClicked= false;
            GameManager.instance.clickCount=1;
        }
        else if(GameManager.instance.clickCount == 1) 
        {
            endNo = currentNumber;
            GameManager.instance.b = endNo;
            Debug.Log("End Number: " + endNo);

          
            GameManager.instance.clickCount=2;
            
            
            
        }
        if (GameManager.instance.clickCount == 2)
        {

            GameManager.instance.CalculateSum(GameManager.instance.a, GameManager.instance.b);
            GameManager.instance.clickCount = 0;
        }

        
    }
}
