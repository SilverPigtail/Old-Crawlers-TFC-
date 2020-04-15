using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RandomTransition : MonoBehaviour
{
    private int currentScene;

    private void SceneCheck()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (currentScene == 1)
        {
            String [] scenes1 = new string[] {"lvl2", "lvl3"};
            int randomIndex = UnityEngine.Random.Range(0, 3);
            if (scenes1[randomIndex].Equals("lvl2"))
            {
                SceneManager.LoadScene("Scenes/TileMapSecond");
            }
            else
            {
                SceneManager.LoadScene("Scenes/TileMapThird");
            }
        }

        if (currentScene == 2)
        {
            String [] scenes1 = new string[] {"lvl1", "lvl3"};
            int randomIndex = UnityEngine.Random.Range(0, 3);
            if (scenes1[randomIndex].Equals("lvl1"))
            {
                SceneManager.LoadScene("TiledMapExp");
            }
            else
            {
                SceneManager.LoadScene("TileMapThird");
            }
        }
        
        if (currentScene == 3)
        {
            String [] scenes1 = new string[] {"lvl1", "lvl2"};
            int randomIndex = UnityEngine.Random.Range(0, 3);
            if (scenes1[randomIndex].Equals("lvl1"))
            {
                SceneManager.LoadScene("Scenes/TiledMapExp");
            }
            else
            {
                SceneManager.LoadScene("Scenes/TileMapSecond");
            }
        }
    }
}
