using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionTypeString : MonoBehaviour
{
    private string[] scenes = new string[] {"lvl1", "lvl2", "lvl3"};
    private int index;
    private string selectedLevel;
    public void OnTriggerEnter2D(Collider2D other)
    {
        index = UnityEngine.Random.Range(0, 2);

        if (index == 5 || index == 4)
        {
            
            if (SceneManager.GetActiveScene().buildIndex == index)
            {
                index = UnityEngine.Random.Range(1, 3);
            
                if (scenes[index].Equals("lvl1"))
                {
                    SceneManager.LoadScene("TiledMapExp");
                }
            
                if (scenes[index].Equals("lvl2"))
                {
                    SceneManager.LoadScene("TileMapSecond");
                }

                if (scenes[index].Equals("lvl3"))
                {
                    SceneManager.LoadScene("TileMapThird");
                }

            
            
            }
            
        }
        
        if (SceneManager.GetActiveScene().buildIndex == index)
        {
            index = UnityEngine.Random.Range(1, 3);
            
            if (scenes[index].Equals("lvl1"))
            {
                SceneManager.LoadScene("TiledMapExp");
            }
            
            if (scenes[index].Equals("lvl2"))
            {
                SceneManager.LoadScene("TileMapSecond");
            }

            if (scenes[index].Equals("lvl3"))
            {
                SceneManager.LoadScene("TileMapThird");
            }

            
            
        }
        
        if (scenes[index].Equals("lvl1"))
        {
            SceneManager.LoadScene("TiledMapExp");
        }
            
        if (scenes[index].Equals("lvl2"))
        {
            SceneManager.LoadScene("TileMapSecond");
        }

        if (scenes[index].Equals("lvl3"))
        {
            SceneManager.LoadScene("TileMapThird");
        }
    
    }
}
