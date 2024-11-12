using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : Character
{
   public player(string name, int health) : base(name, health) {}

    // Method to increase health by a specified amount
    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log($"{Name} healed by {amount}. Current health: {Health}");
    }




}
