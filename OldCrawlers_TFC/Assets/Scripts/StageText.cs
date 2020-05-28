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
        textMeSh.text = "Room " + SceneManager.GetActiveScene().buildIndex;
    }
}
