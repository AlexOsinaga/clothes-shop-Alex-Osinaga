using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f;    // Movement speed of the character
    private Vector2 direction; // Direction the character is moving in

    // Update is called once per frame
   void Update()
    {
        // Get the horizontal and vertical input axis values
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Set the direction of the character based on the input axis values
        direction = new Vector2(horizontalInput, verticalInput).normalized;

        // Move the character in the direction it is facing at a constant speed
        Vector3 newPosition = transform.position + new Vector3(direction.x, direction.y, 0f) * speed * Time.deltaTime;
        //Vector3 newPosition = transform.position + new Vector3(direction.x, direction.y, 0f) * speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
