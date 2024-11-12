using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
       // Create a Player and an Enemy character
        player player = new player("Subhi", 80);
        enemy enemy = new enemy("Zarifeh", 100);

        // Print their Name and Health in the Unity Console
        Debug.Log($"Player: {player.Name}, Health: {player.Health}");
        Debug.Log($"Enemy: {enemy.Name}, Health: {enemy.Health}");

        // Test the Heal() method on the player
        player.Heal(10); // Heals the player by 10, should be 90

        // Test the Attack() method on the enemy to reduce the player's health
        enemy.Attack(player, 20); // Reduces player's health by 20, should be 70
    }
}



