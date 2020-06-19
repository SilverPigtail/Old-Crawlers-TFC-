using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/***
 * This script casts the animations created for the knightPlayer. This script will cast the Animator editor from Unity
 * that will execute the certain animation based on the movement.
 */
public class PlayerAnimation : MonoBehaviour
{
    /***
     * anim -> The parameter of the Animation tool of Unity, used to call and use the animations stored on it.
     */
    private Animator anim;

    /**
     * staticDirections -> array of strings of the static animations.
     */
    public String[] staticDirections =
        {"Static N", "Static NW", "Static W", "Static SW", "Static S", "Static SE", "Static E", "Static NE"};

    /**
     * runDirections -> array of strings of the movement directions.
     */
    public String[] runDirections = {"Run N", "Run NW", "Run W", "Run SW", "Run S", "Run SE", "Run E", "Run NE"};

    /**
     * attackDirections -> array of strings of the attack directions.
     */
    public String[] attackDirections =
        {"Attack N", "Attack NW", "Attack W", "Attack SW", "Attack S", "Attack SE", "Attack E", "Attack NE"};

    /***
     * lastDirection -> int that will get the last direction that the knightPlayer was.
     */
    int lastDirection;

    /***
     * This function will execute when the scene loads, and its job is to get the movement vectors in purpose to debug
     * the animations.
     */
    private void Awake()
    {
        anim = GetComponent<Animator>();

        float result1 = Vector2.SignedAngle(Vector2.up, Vector2.right);
        Debug.Log("R1 " + result1);

        float result2 = Vector2.SignedAngle(Vector2.up, Vector2.left);
        Debug.Log("R2 " + result2);

        float result3 = Vector2.SignedAngle(Vector2.up, Vector2.down);
        Debug.Log("R3 " + result3);
    }

    /***
     * This function will set the direction cheking if the player is moving or not, setting the array of the static,
     * run or attacking directions dependendig of the direction magnitude and the attacking boolean.
     */
    public void SetDirection(Vector2 _direction, bool isAttacking)
    {
        String[] directionArray = null;

       if (_direction.magnitude < 0.01)
        {
            directionArray = staticDirections;
        }
        else
        {
            directionArray = runDirections;

            lastDirection = DirectionToIndex(_direction);
        }
        
        if (isAttacking)
        {
           directionArray = attackDirections;
           
           anim.Play(attackDirections[lastDirection]);
        }
        else
        {
           anim.Play(directionArray[lastDirection]);   
        }
       
        


        
    }

    /***
     * This function will sect the last direction of the player in order to cast the correct animation.
     */
    private int DirectionToIndex(Vector2 _direction)
    {
        Vector2 norDir = _direction.normalized;

        float step = 360 / 8;
        float offset = step / 2;


        float angle = Vector2.SignedAngle(Vector2.up, norDir);

        if (angle < 0)
        {
            angle += 360;
        }

        float steptCount = angle / step;
        return Mathf.FloorToInt(steptCount);

    }
    
    

}
