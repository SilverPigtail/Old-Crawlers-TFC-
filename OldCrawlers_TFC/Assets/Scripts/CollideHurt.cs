using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
