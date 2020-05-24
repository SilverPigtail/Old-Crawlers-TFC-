using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    private HealthSystem healthCharacter;
    public Slider hPBar;
    public Text hPValue;
    
    
    // Start is called before the first frame update
    void Start()
    {
        healthCharacter = FindObjectOfType<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        hPBar.maxValue = healthCharacter.maxHP;
        hPBar.value = healthCharacter.currentHP;
        hPValue.text = "Heatlh Points: " + healthCharacter.currentHP + "/" + healthCharacter.maxHP;

        if (hPBar.value == 0)
        {
            hPValue.text = "GAME OVER";
        }
    }
}
