using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***
 * This script allows the enemy to give damage to the player. It is attached to the character's attack colliders.
 */
public class CollideHurt : MonoBehaviour
{
    public int damageGiven = 2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /***
     * This function will execute when the attack colliders interact with an NPC, giving a int as a damage value.
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            NpcHealthSystem npcHealthS;
            npcHealthS = other.gameObject.GetComponent<NpcHealthSystem>();
            
            npcHealthS.HurtNpc(damageGiven);
        }
    }
}
