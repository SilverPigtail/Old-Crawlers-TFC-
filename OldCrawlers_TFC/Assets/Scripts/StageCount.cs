using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StageCount : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    private int sCount;

    // Start is called before the first frame update
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
