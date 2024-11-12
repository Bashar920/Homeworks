using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : Character
{
 public enemy(string name, int health) : base(name, health) {}

    // Method to lower the health of another character by a specified amount
    public void Attack(Character target, int damage)
    {
        target.Health -= damage;
        Debug.Log($"{Name} attacked {target.Name} for {damage} damage. {target.Name}'s health is now {target.Health}");
    }


}
