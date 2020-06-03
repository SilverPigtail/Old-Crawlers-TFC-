using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float moveSpeed = 1.0f;

    private Animator cAnimator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
