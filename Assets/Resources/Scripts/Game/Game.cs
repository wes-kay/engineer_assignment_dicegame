using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Game
{
    public List<Player> players = new List<Player>();
    public Game()
    {
        //TODO: Pull data from login, online, or device to create players. Keeping it two static entities for demonstration and gameplay
        player = new Player("Player 1", true);
        players.Add(player);
        bot = new Player("Bot");
        players.Add(bot);
    }

    public Player player;
    public Player bot;
    public byte currentPlayer;
    bool _isRolling = false;

    ushort round = 0;
    public Player GetCurrentPlayer() => players[currentPlayer];

    public void SetPlayerRoll()
    {
        SetCurrentPlayerTurn();
    }

    internal void StartGame()
    {
        currentPlayer = 0;
        round = 0;
        foreach (var player in players)
        {
            player.ResetGame();
        }
        GameManager.eventHandler.IsRolling = true;
    }

    public void TallyScores()
    {
        if(round == 11)
        {
            ushort tempWins = 0;
            Player tempPlayer = player;
            foreach (var player in players)
            {
                ushort tempPlayerWins = player.gameWins;
                if(tempPlayerWins > tempWins)
                {
                    tempWins = tempPlayerWins;
                    tempPlayer = player;
                }
            }
            //The winner is temp player
        }
        else if (players.Any(x => x.currentRoll.Value != players.FirstOrDefault().currentRoll.Value))
        {
            var outcome = "Tie";
        }
        else
        {
            foreach (var player in players)
            {
                if (player.CanReroll())
                {
                    if (player.isMainPlayer)
                    {
                        player.Reroll();
                        GameManager.dice.RollDice();
                    }
                    else
                    {
                        //Calculate reroll for bot
                    }
                }
            }

            ushort tempScore = 0;
            Player tempPlayer = player;
            foreach (var player in players)
            {
                ushort tempPlayerScore = player.currentRoll.Value;
                if (tempPlayerScore > tempScore)
                {
                    tempScore = tempPlayerScore;
                    tempPlayer = player;
                }
            }
            tempPlayer.gameWins++; 

            //Caluclate score
            round++; 
        }
    }

    void SetCurrentPlayerTurn()
    {
        currentPlayer++; 
        if(currentPlayer > players.Count - 1)
        {
            currentPlayer = 0;
            TallyScores();
        }
    }
}
