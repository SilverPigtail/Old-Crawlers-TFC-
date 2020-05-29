using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
   
   public void PlayGame()
   {
      PlayerPrefs.SetInt("CharacterLive", 50);
      PlayerPrefs.SetInt("StageCount", 0);
      //PlayerPrefs.SetFloat("TrackVolume", -80);
      
      if (SceneManager.GetActiveScene().buildIndex == 0)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +6);
      }
      else
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  - 5);
      }
      
      //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
      //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
   }

   public void QuitGame()
   {
      Debug.Log("Game quit");
      Application.Quit();
   }
}
