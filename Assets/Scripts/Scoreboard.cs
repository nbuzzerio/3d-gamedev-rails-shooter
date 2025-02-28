using System;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] TMP_Text scoreboardText;
    int score = 0;
    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreboardText.text = score.ToString();
    }
}
