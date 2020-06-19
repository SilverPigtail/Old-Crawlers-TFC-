using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/***
 * This script allows the knightPlayer to move around the scenes.
 */
public class PlayerMovement : MonoBehaviour
{
    /**
     * rb -> Rigidbody2D parameter that is attached to the sprite and make it an object with physics.
     */
    private Rigidbody2D rb;
    
    /**
     * moveH -> float that allows the Rigidbody2D object to get the horizontal axis to move.
     * moveY -> float that allows the Rigidbody2D object to get the vertical axis to move.
     */
    private float moveH, moveV;
    
    /**
     * moveSpeed -> float that establish the movement speed of the Rigidbody2D object.
     */
    [SerializeField] private float moveSpeed = 1.0f;


    /***
     * This function gets the Rigidbody2D object when the scene loads.
     */
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /***
     * This function will make the knightPlayer moves when any arrow key is being pressed. It will also send the type
     * of animation that the knightPlayer will have by sending a boolean to the PlayerAnimation script.
     */
    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * moveSpeed;
        moveV = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(moveH, moveV);
        
        Vector2 direction = new Vector2(moveH, moveV);

        if (Input.GetKey(KeyCode.Z))
        {
            FindObjectOfType<PlayerAnimation>().SetDirection(direction, true);
        }
        else
        {
            FindObjectOfType<PlayerAnimation>().SetDirection(direction, false);
        }
        

    }
    
    
}
