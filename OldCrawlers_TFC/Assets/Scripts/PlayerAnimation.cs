using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    public String[] staticDirections =
        {"Static N", "Static NW", "Static W", "Static SW", "Static S", "Static SE", "Static E", "Static NE"};

    public String[] runDirections = {"Run N", "Run NW", "Run W", "Run SW", "Run S", "Run SE", "Run E", "Run NE"};

    public String[] attackDirections =
        {"Attack N", "Attack NW", "Attack W", "Attack SW", "Attack S", "Attack SE", "Attack E", "Attack NE"};

    int lastDirection;

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
