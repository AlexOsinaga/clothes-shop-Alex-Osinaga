using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    public int startingBalance = 100;    // The starting balance of the player
    private int balance;                 // The current balance of the player

    public int Balance
    {
        get { return balance; }
    }

    private void Start()
    {
        // Set the starting balance
        balance = startingBalance;
    }

    public void Add(int amount)
    {
        balance += amount;
    }

    public void Subtract(int amount)
    {
        balance -= amount;
    }
}
