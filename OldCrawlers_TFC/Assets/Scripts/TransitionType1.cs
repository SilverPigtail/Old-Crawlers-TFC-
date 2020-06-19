using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

using TMPro;

/***
 * This script allows the player to get to other scenes when hits the collider of the doors.
 */
public class TransitionType1 : MonoBehaviour
{

    /***
     * mapRandomValue -> random number that will choose the scene that is going to load.
     */
    private int mapRandomValue;
    
    /**
     * numberToChoose -> an int array that represents the scenes of the current game.
     */
    private int[] numberToChoose = new int[] {1, 2, 3, 4, 5};
    
    /**
     * generatedNumber -> the scene that has been taken from the "numberToChoose" array.
     */
    private int generatedNumber;

    /**
     * count -> the "stageCount" that is saved and recovered on the PlayerPrefs library.
     */
    private int count;
    
    /***
     * This functions allows the developer to debug the values that loads the scene to make sure that it works
     * properly.
     */
    IEnumerator RecalculateRandom()
    {
        while (true)
        {
            // Debug.Log("Recalculando random de niveles...");
            mapRandomValue = UnityEngine.Random.Range(0, 5);    
            yield return new WaitForSeconds(1);
        }
        
        
    }
    
    /***
     * This function starts when the scene loads ant get the StageCount value from the PlayerPrefs lubrary and execute
     * the RecalculateRandom debug function.
     */
    private void Start()
    {
       
        StartCoroutine(RecalculateRandom());
        count = PlayerPrefs.GetInt("StageCount");

    }

    /***
     * This function will load the random scene when the an object interact with the door collider.
     */
    public void OnTriggerEnter2D(Collider2D other)
    {
        count++;
        PlayerPrefs.SetInt("StageCount", count);
        
       
        mapRandomValue = UnityEngine.Random.Range(0, 5);
        generatedNumber = numberToChoose[mapRandomValue];
            
          

            if (SceneManager.GetActiveScene().buildIndex == generatedNumber)
            {
                mapRandomValue = UnityEngine.Random.Range(0, 5);
                SceneManager.LoadScene(generatedNumber);
            }
            else
            {
                SceneManager.LoadScene(generatedNumber);
                
            }
            
           
    }
}
