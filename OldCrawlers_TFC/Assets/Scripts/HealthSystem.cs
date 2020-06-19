using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***
 * This class manages the health points of the main player.
 */
public class HealthSystem : MonoBehaviour
{
    /**
     * currentHP -> the current health points of the character.
     */
    public int currentHP;
    
    /**
     * maxHP -> the maximum Health Points of the character.
     */
    public int maxHP;
    
    
    /**
     * This function will execute when the scene loads. It gets the maximum HP from the "PlayerPrefs" library.
     */
    void Start()
    {
        currentHP = PlayerPrefs.GetInt("CharacterLive");
    }


    /**
     * This function allows the enemy to hurt the player.
     */
    public void HurtCharacter(int damageTaken)
    {
        currentHP -= damageTaken;

        if (currentHP <= 0)
        {
            gameObject.SetActive(false);
            
        }
        
        saveLife(currentHP);
        
    }

    /**
     * This function allows the program to store the Health Points on the PlayerPrefs library.
     */
    public void saveLife(int value)
    {
        PlayerPrefs.SetInt("CharacterLive", value);
    }


}
