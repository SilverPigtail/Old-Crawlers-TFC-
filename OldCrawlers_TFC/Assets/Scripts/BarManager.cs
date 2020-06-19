using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/***
 * This script manages the hp bar of the interface (that is currently a slider).
 */
public class BarManager : MonoBehaviour
{
    /**
     * healthCharacter -> The health points of the character that the HealthSystem script manages.
     */
    private HealthSystem healthCharacter;
    
    /***
     * hPBar -> Slider that shows the current HP.
     */
    public Slider hPBar;
    
    /**
     * hPValue -> The informative text that its above the health bar.
     */
    public Text hPValue;
    
    
    /**
     * Start is called before the first frame update. This function will get the HealthSystem script.
     */
    void Start()
    {
        healthCharacter = FindObjectOfType<HealthSystem>();
    }

    /**
     * Update is called once per frame. This function will update the slider based on the health points that the player
     * currently has. If the HP reach 0, the game will finish, then, the player can press the space key to return to the
     * main menu.
     */
    void Update()
    {
        hPBar.maxValue = healthCharacter.maxHP;
        hPBar.value = healthCharacter.currentHP;
        hPValue.text = "Heatlh Points: " + healthCharacter.currentHP + "/" + healthCharacter.maxHP;

        if (hPBar.value == 0)
        {
            hPValue.text = "GAME OVER, PRESS SPACE";

            if (Input.GetKeyDown(KeyCode.Space))
            {
             SceneManager.LoadScene("MainMenuScene");
            }
        }
    }
}
