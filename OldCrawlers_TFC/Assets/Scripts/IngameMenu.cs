using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/***
 * This class models the menu that appears when you press the "escape" key.
 */
public class IngameMenu : MonoBehaviour
{
    /***
     * isPaused -> boolean parameter that check if the game is paused or not.
     */
    public static bool isPaused = false;

    /***
     * pauseInterface -> GameObject that models the interface.
     */
    public GameObject pauseInterface;
    

    /***
     * This function is called once per frame, and it will cast the pause menu when the "Z" key is pressed.
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    /***
     * This function will pause the game by setting the time scale at 0 and setting the menu created on Unity in active.
     */
    void PauseGame()
    {
        pauseInterface.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    /***
     * This function will return the game to its normal state by returning the time to its normal state.
     */
    public void ResumeGame()
    {
        pauseInterface.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    /***
     * This function will quit the game.
     */
    public void QuitGame()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }

    /***
     * This function will return the game to the main menu scene.
     */
    public void ReturnToMenu()
    {
        Debug.Log("Returning to the main menu");
        SceneManager.LoadScene("MainMenuScene");
    }
}
