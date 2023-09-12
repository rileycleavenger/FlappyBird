using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}
