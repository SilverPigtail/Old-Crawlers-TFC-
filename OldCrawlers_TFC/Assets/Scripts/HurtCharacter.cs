using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/***
 * This script allows the enemy to hurt the character by detecting the colliders (complemented with the HealthSystem script).
 */
public class HurtCharacter : MonoBehaviour
{
    /***
     * healthSystem -> Parameter that calls the HealthSystem class.
     */
    private HealthSystem healthSystem;
    
    /***
     * timeWaitedDamage -> the time that the enemy takes to make damage.
     */
    public float timeWaitedDamage = 0.5f;
    
    /***
     * isColliding -> boolean parameter that detects if the enemy is colliding with the player.
     */
    public bool isColliding;
    
    /***
     * damageGiven -> the damage that the enemy give when is colliding with the player.
     */
    [SerializeField] private int damageGiven = 10;
    
    /***
     * This function will start when the scene loads. It gets the healthSystem script by calling it.
     */
    void Start()
    {
        healthSystem = FindObjectOfType<HealthSystem>();
    }

    /***
     * This function will execute in every fame. It checks if the enemy is colliding with the player, if it is true,
     * uses the HealthSystem class to decrease Health Points.
     */
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

    /***
     * This function executes when the player enters in the collision of the enemy. If the object that is colliding
     * with the enemy has the "Player" tag, execute the HurtCharacter function from the HealthSystem script.
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
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
