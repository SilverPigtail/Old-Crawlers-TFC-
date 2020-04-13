using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class TransitionType3 : MonoBehaviour
{
    private int mapRandomValue;
    private int[] numberToChoose = new int[] {1, 2};
    private int generatedNumber;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        Random rnd = new Random();
        mapRandomValue = rnd.Next(numberToChoose.Length);
        generatedNumber = numberToChoose[mapRandomValue];

        if (other.CompareTag("Player") && !other.isTrigger && mapRandomValue == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.CompareTag("Player") && !other.isTrigger && mapRandomValue == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
