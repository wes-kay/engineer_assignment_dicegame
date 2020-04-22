using TMPro;
using UnityEngine;

public class StatsView : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI playerWinsStat, enemyWinsStat, playerSumStat, enemySumStat;

    public void SetStats(Player statA, Player statB)
    {
        playerWinsStat.text = $"Player Wins: {statA.stats.ReturnSumLinq()}";
        enemyWinsStat.text = $"Enemy Wins: {statB.stats.ReturnSumLinq()}";
        playerSumStat.text = $"Sum of player rolls: {statB.stats.ReturnSumLinq()}";
        enemySumStat.text = $"Sum of enemy rolls: {statB.stats.ReturnSumLinq()}";
    }
}
