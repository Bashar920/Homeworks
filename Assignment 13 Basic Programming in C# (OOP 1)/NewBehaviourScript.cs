using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        player player1 = new player();
        player player2 = new player();

        player1.InitializePlayer("Player One", 50);
        player2.InitializePlayer("Player Two", 75);

        player1.Heal(20);               
        player1.Heal(true);            

        player2.Heal(15);             
        player2.Heal(true);            

        player.ShowPlayerCount();
    }
}



