using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOverScore : MonoBehaviour
{
    [SerializeField] TMP_Text Scoretext;

    int Score ;
    private void Start()
    {
        Score = GameManager.instance.score;
        Scoretext.text = Score.ToString();
    }
}
