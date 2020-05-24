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
        
    }
}
