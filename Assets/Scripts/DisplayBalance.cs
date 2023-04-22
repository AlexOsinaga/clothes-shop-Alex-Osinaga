using UnityEngine;
using UnityEngine.UI;

public class DisplayBalance : MonoBehaviour
{
    public PlayerBalance playerBalance;  // Reference to the PlayerBalance script
    public Text balanceText;             // Reference to the UI Text component

    private void Update()
    {
        // Update the UI text with the player's current balance
        balanceText.text = "Balance: $" + playerBalance.Balance;
    }
}
