using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

/***
 * This script change the textmesh stage text of the current scene.
 */
public class StageText : MonoBehaviour
{
    /**
     * textMeSh -> the CurrentScene textMesh object of the game interface.
     */
    private TextMeshProUGUI textMeSh;
    
    /***
     * This function will execute when the scene loads. It gets the textMesh from the Unity editor.
     */
    void Start()
    {
        textMeSh = GetComponent<TextMeshProUGUI>();
    }

    /***
     * Update is called once per frame. This function will set the text of the textMesh interface to the current scene
     * number.
     */
    void Update()
    {
        textMeSh.text = "Room " + SceneManager.GetActiveScene().buildIndex;
    }
}
