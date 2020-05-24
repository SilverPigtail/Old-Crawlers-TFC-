using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtCharacter : MonoBehaviour
{
    private float timeWaited = 2f;
    private bool rel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (rel)
        {
            timeWaited -= Time.deltaTime;
            if (timeWaited <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        } */
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player") // You can use <<other.collider.compareTag("Player")>> to make this condition.
        {
            //other.gameObject.SetActive(false);
            other.gameObject.GetComponent<HealthSystem>().HurtCharacter(10);
            //rel = true;
        }
    }


}
