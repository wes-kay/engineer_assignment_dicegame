using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Player
{
    /// <summary>
    /// Assignes the name and the human player
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isMainPlayer"></param>
    public Player(string name, bool isMainPlayer = false)
    {
        //TODO: Check serialzied data for player name in binary file or online and set the data, but for this project it will just be application memory. 
        stats = new Stats();
        //TODO: validate input name
        this.name = name;
    }

    //TODO serialize this class out to store player
    public string name;
    public Stats stats;
    public Roll currentRoll = null;
    byte rerolls = 3;
    public bool isMainPlayer;
    public ushort gameWins = 0; 

    public void ResetGame()
    {
        currentRoll = null;
        rerolls = 3;
        gameWins = 0;
    }
    public void Reroll()
    {
        rerolls -= 1;
    }

    public void AddRoll(Roll roll)
    {
        currentRoll = roll;
        stats.AddRoll(roll.Value);
    }

    public bool CanReroll() => (rerolls > 0 && isMainPlayer) ? currentRoll.isEven : !currentRoll.isEven;
}