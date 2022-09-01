using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    public Text ScoreText;
    public void IncrementScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
    }
    void Awake()
    {
        inst = this;
    }
 
}
