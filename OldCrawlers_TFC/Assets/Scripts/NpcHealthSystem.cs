using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcHealthSystem : MonoBehaviour
{

    public int NpcCurrentHP;
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
