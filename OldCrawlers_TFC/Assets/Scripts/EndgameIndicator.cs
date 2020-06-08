using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameIndicator : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    
    
    private int currentCount;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

        currentCount = PlayerPrefs.GetInt("EnemyCount");
        textMesh.text = "Remaining enemies: " + currentCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCount == 0)
        {
            SceneManager.LoadScene("MainMenuScene");
        }
        else
        {
            currentCount = PlayerPrefs.GetInt("EnemyCount");
            textMesh.text = "Remaining enemies: " + currentCount;
        }
    }
    

}
