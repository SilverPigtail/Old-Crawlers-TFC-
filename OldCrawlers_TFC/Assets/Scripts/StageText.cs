using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StageText : MonoBehaviour
{
    private string currentStage;
    private Scene currentScene;
    private TextMeshProUGUI textMeSh;
    
    // Start is called before the first frame update
    void Start()
    {
        textMeSh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            textMeSh.text = "Room 1";
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            textMeSh.text = "Room 2";
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            textMeSh.text = "Room 3";
        }

        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            textMeSh.text = "Room 4";
        }

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            textMeSh.text = "Room 5";
        }
        
       
    }
}
