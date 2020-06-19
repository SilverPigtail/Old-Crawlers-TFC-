using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/***
 * This script models the textMesh indicator that shows the enemy count that the player has to slay.
 */
public class EndgameIndicator : MonoBehaviour
{
    /**
     * textMesh -> the textMesh object that shows in the game interface.
     */
    public TextMeshProUGUI textMesh;
    
    
    /**
     * currentCount -> The current count of the remaining enemies.
     */
    private int currentCount;

    /**
     * Start is called before the first frame update. This function will get the EnemyCount from the PlayerPrefs library
     * and set it on the textMesh object.
     */
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        currentCount = PlayerPrefs.GetInt("EnemyCount");
        textMesh.text = "Remaining enemies: " + currentCount;
    }

    /**
     * Update is called once per frame. This function will check if there are no remaining enemies. If this is true,
     * the game will finish by sending the player to the main menu.
     */
    void Update()
    {
        if (currentCount == 0)
        {
            SceneManager.LoadScene("MainMenuScene");
        }
        else
        {
            currentCount = PlayerPrefs.GetInt("EnemyCount");
            textMesh.text = "Remaining enemies: " + currentCount;
        }
    }
    

}
