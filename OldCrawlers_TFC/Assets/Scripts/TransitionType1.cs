using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;


public class TransitionType1 : MonoBehaviour
{
    //public String sceneToLoad;
    private int mapRandomValue;
    private int[] numberToChoose = new int[] {1, 2, 3};
    private int generatedNumber;

    
    IEnumerator RecalculateRandom()
    {
        while (true)
        {
            Debug.Log("Recalculando random de niveles...");
            mapRandomValue = UnityEngine.Random.Range(1, 3);    
            yield return new WaitForSeconds(1);
        }
        
        
    }
    
    private void Start()
    {

        StartCoroutine(RecalculateRandom());
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        
       
        mapRandomValue = UnityEngine.Random.Range(1, 3);
        generatedNumber = numberToChoose[mapRandomValue];
            
            Debug.Log("Número aleatorio;: " + mapRandomValue + ", número escogido de la lista " + generatedNumber);


            if (SceneManager.GetActiveScene().buildIndex == generatedNumber)
            {
                mapRandomValue = UnityEngine.Random.Range(1, 3);
                SceneManager.LoadScene(generatedNumber);
            }
            else
            {
                SceneManager.LoadScene(generatedNumber);
                
            }
            
           
    }
}
