using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

using TMPro;

public class TransitionType1 : MonoBehaviour
{
    //public String sceneToLoad;
    private int mapRandomValue;
    private int[] numberToChoose = new int[] {1, 2, 3, 4, 5};
    private int generatedNumber;

    private TextMeshProUGUI textMesh;
    private int stageCount;
    
    IEnumerator RecalculateRandom()
    {
        while (true)
        {
            Debug.Log("Recalculando random de niveles...");
            mapRandomValue = UnityEngine.Random.Range(0, 5);    
            yield return new WaitForSeconds(1);
        }
        
        
    }
    
    private void Start()
    {
       
        StartCoroutine(RecalculateRandom());

        /*stageCount = 0;
        textMesh = GetComponent<TextMeshProUGUI>();*/
    }

    public void OnTriggerEnter2D(Collider2D other)
    {


       //textMesh.text = stageCount.ToString();
       
        mapRandomValue = UnityEngine.Random.Range(0, 5);
        generatedNumber = numberToChoose[mapRandomValue];
            
            Debug.Log("Número aleatorio;: " + mapRandomValue + ", número escogido de la lista " + generatedNumber);


            if (SceneManager.GetActiveScene().buildIndex == generatedNumber)
            {
                mapRandomValue = UnityEngine.Random.Range(0, 5);
                SceneManager.LoadScene(generatedNumber);
            }
            else
            {
                SceneManager.LoadScene(generatedNumber);
                
            }
            
           
    }
}
