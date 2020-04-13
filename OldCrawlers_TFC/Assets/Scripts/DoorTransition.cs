using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class DoorTransition : MonoBehaviour
{
    public String sceneToLoad;
    private int mapGenerator;

    
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        Random rnd = new Random();
        mapGenerator = rnd.Next(0, 3);
            
            if (other.CompareTag("Player") && !other.isTrigger && mapGenerator == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            if (other.CompareTag("Player") && !other.isTrigger && mapGenerator == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }

            if (other.CompareTag("Player") && !other.isTrigger && mapGenerator == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }
    }
}
