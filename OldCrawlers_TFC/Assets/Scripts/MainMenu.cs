using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/***
 * This script models the main menu of the game.
 */
public class MainMenu : MonoBehaviour
{
   
   
   /***
    * This function allows the program to start the execution. This function will set important game values like the
    * health points of the character or the enemy count randomly generated.
    */
   public void PlayGame()
   {
      PlayerPrefs.SetInt("CharacterLive", 50);
      PlayerPrefs.SetInt("StageCount", 0);
      PlayerPrefs.SetInt("EnemyCount", Random.Range(10, 15));
      
      if (SceneManager.GetActiveScene().buildIndex == 0)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +6);
      }
      else
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  - 5);
      }
   }

   /***
    * This function will quit the game.
    */
   public void QuitGame()
   {
      Debug.Log("Game quit");
      Application.Quit();
   }
}
