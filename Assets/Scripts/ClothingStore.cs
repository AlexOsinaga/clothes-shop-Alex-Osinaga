using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingStore : MonoBehaviour
{
 public GameObject character;            // Drag and drop the 2D character GameObject to this variable in the Inspector
    public GameObject[] dressesForSale;     // Drag and drop the dresses GameObjects that are for sale to this array in the Inspector
    public int[] dressPrices;               // Set the prices of the dresses in this array in the Inspector

    private int selectedDressIndex = -1;
    private PlayerBalance playerBalance;
    private SpriteRenderer characterSpriteRenderer;

    private void Start()
    {
        // Get the PlayerBalance script attached to the player
        playerBalance = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBalance>();

        // Get the SpriteRenderer component of the character
        characterSpriteRenderer = character.GetComponent<SpriteRenderer>();
    }

    public void SelectDress(int index)
    {
        // Set the selected dress index
        selectedDressIndex = index;
    }

    public void BuyDress()
    {
        if (selectedDressIndex != -1)
        {
            // Check if the player has enough money to purchase the dress
            if (playerBalance.Balance >= dressPrices[selectedDressIndex])
            {
                // Subtract the cost from the player's balance
                playerBalance.Subtract(dressPrices[selectedDressIndex]);

                // Equip the dress on the character
                characterSpriteRenderer.sprite = dressesForSale[selectedDressIndex].GetComponent<SpriteRenderer>().sprite;

                // Reset the selected dress index
                selectedDressIndex = -1;
            }
            else
            {
                // Display a message to the player that they don't have enough money
                Debug.Log("You don't have enough money to purchase this dress!");
            }
        }
    }

    public void SellDress()
    {
        if (characterSpriteRenderer.sprite != null)
        {
            // Add the price of the currently equipped dress to the player's balance
            playerBalance.Add(dressPrices[selectedDressIndex]);

            // Unequip the dress from the character
            characterSpriteRenderer.sprite = null;

            // Reset the selected dress index
            selectedDressIndex = -1;
        }
    }
}
