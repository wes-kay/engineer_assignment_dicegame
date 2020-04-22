using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Stats 
{
    string name; 
    List<ushort> rolls = new List<ushort>();
    public uint gamesPlayed = 0; 

    //Wouldn't suggest using Linq on a mobile project but it's a way to do it, also adding non linq performant way. 
    public uint ReturnSumLinq() => (rolls.Count == 0) ? 0 : (uint)rolls.Select(x => (int)x).ToArray().Sum();
    public uint ReturnSum()
    {
        if(rolls.Count == 0)
        {
            return 0;
        }

        uint n = 0;
        for(int i = 0; i < rolls.Count(); i++)
        {
            n += rolls[i];
        }
        return n;
    }

    public void AddRoll(ushort value) => rolls.Add(value);
    public ushort GetLastRoll() => rolls[rolls.Count - 1];
}
