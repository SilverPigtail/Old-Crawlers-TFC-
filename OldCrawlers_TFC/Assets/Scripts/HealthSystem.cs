using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int currentHP;
    public int maxHP;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHP = PlayerPrefs.GetInt("CharacterLive");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtCharacter(int damageTaken)
    {
        currentHP -= damageTaken;

        if (currentHP <= 0)
        {
            gameObject.SetActive(false);
            
        }
        
        saveLive(currentHP);
        
    }

    public void saveLive(int value)
    {
        PlayerPrefs.SetInt("CharacterLive", value);
    }


}
