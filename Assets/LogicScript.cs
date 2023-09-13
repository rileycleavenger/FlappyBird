using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public bool firstTime;

    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd){
        if(!firstTime){
            firstTime = true;
            playerScore = 0;
        }
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

}
