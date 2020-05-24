using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtCharacter : MonoBehaviour
{
    private HealthSystem healthSystem;
    public float timeWaitedDamage = 0.5f;
    public bool isColliding;
    [SerializeField] private int damageGiven = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        healthSystem = FindObjectOfType<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        {
          timeWaitedDamage -= Time.deltaTime;
          if (timeWaitedDamage <= 0)
          {
              healthSystem.HurtCharacter(damageGiven);
              timeWaitedDamage = 0.5f;

          }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player") // You can use <<other.collider.compareTag("Player")>> to make this condition.
        {
            other.gameObject.GetComponent<HealthSystem>().HurtCharacter(damageGiven);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            isColliding = true;

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            isColliding = false;
            timeWaitedDamage = 2f;
        }
    }
}
