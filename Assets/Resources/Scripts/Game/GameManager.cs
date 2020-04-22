using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum BotPlaystyle
    {
        Random, 
        AllUnderThree,
        RandomUnderThree
    }

    [SerializeField]
    BotPlaystyle botPlayStyle;

    public static Game game = new Game();
    public static Dice dice;
    public static EventHandler eventHandler;
    public static DiceView diceView;
    private void FixedUpdate()
    {
       if (eventHandler.IsRolling && Input.GetMouseButtonUp(0))
        {
            dice.RollDice();
            eventHandler.IsRolling = false;
        }
    }
}
