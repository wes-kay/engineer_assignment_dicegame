using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class GameView : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Outcome, player1, player2, player1Score, player2Score; 

    public void UpdateOutcome(string s)
    {
        Outcome.text = s;
    }

    public void SetNames(Player player1, Player player2)
    {
        this.player1.text = $"{player1.name} Roll:";
        this.player2.text = $"{player2.name} Roll:";
    }

    public void SetScore(Player player1, Player player2)
    {
        
    }
}
