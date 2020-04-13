using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class TransitionType1 : MonoBehaviour
{
    //public String sceneToLoad;
    private int mapRandomValue;
    private int[] numberToChoose = new int[] {1, 2, 3};
    private int generatedNumber;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        Random rnd = new Random();
        mapRandomValue = rnd.Next(numberToChoose.Length);
        generatedNumber = numberToChoose[mapRandomValue];

            if (other.CompareTag("Player") && !other.isTrigger && mapRandomValue == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            if (other.CompareTag("Player") && !other.isTrigger && mapRandomValue == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
            
            if (other.CompareTag("Player") && !other.isTrigger && mapRandomValue == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }
    }
}
