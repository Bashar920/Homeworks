using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   public string playerName;
    public int health;

    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++; 
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"{playerName} healed by {amount}. Current health: {health}");
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100; 
            Debug.Log($"{playerName} fully restored to {health} health.");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"Total number of players: {playerCount}");
    }






}
