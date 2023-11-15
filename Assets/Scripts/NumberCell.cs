using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NumberCell : MonoBehaviour
{
    public static NumberCell Instance;

    [SerializeField] private TMP_Text numberText;
    public int num;
    

    private void Start()
    {
        Instance = this;
        SetNumber();
        Button button = GetComponentInChildren<Button>();
       // button.onClick.AddListener(() => ResetCell(button));
    }
    public void SetNumber()
    {
       // num= number;
        num = Random.Range(1,10);
        
        if (numberText == null)
        {
            numberText = GetComponentInChildren<TMP_Text>();
        }

        // Update the text to display the number
        else {
            numberText.text = num.ToString();
        }
        
    }
    public int GetNumber()
    {
       
        return num;

       
    }

    public int ResetCell(Button button)
    {
        TMP_Text buttonNumber = button.GetComponentInChildren<TMP_Text>();
        int currentNumber =int.Parse(buttonNumber.text);
        int num = int.Parse(numberText.text);

        do
        {
            num = Random.Range(1, 10);

            // Repeat until the generated number is different from the excluded number
        } while (num == currentNumber);

        return num;
    }
}

