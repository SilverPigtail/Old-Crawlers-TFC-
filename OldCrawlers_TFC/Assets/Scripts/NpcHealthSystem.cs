using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***
 * This sctipt manages the health system of the enemy.
 */
public class NpcHealthSystem : MonoBehaviour
{

    /***
     * NpcCurrentHP -> Int for the current health points of the enemy.
     */
    public int NpcCurrentHP;
    
    /***
     * NpcMaxHP -> Int for the maximum health points of the enemy.
     */
    public int NpcMaxHP;

    private int enemyCount;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    
    /***
     * This function allows the player to hurt the enemy by decreasing its health points. If the enemy is killed,
     * the game will add +1 to the enemyCount int in the PlayerPrefs system.
     */
    public void HurtNpc(int dmgTaken)
    {
        NpcCurrentHP -= dmgTaken;

        if (NpcCurrentHP <= 0)
        {
            Destroy(gameObject);

            enemyCount = PlayerPrefs.GetInt("EnemyCount");

            enemyCount--;
            
            PlayerPrefs.SetInt("EnemyCount", enemyCount);

        }
    }
}
