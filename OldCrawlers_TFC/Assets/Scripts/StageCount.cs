using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


/***
 * This script will set the stage counter of the interface. 
 */
public class StageCount : MonoBehaviour
{
    /***
     * textMesh -> The text object of the interface.
     */
    public TextMeshProUGUI textMesh;

    /***
     * sCount -> the stage count parameter.
     */
    private int sCount;

    /***
     * This function is called when the scene loads. It gets the textmesh object and set the stage count on it based on
     * the stageCount value of the PlayerPrefs library.
     */
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        sCount = PlayerPrefs.GetInt("StageCount");
        textMesh.text = "Total stages: " + sCount.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
