using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class TransitionType3 : MonoBehaviour
{
    private int mapRandomValue;
    private int[] numberToChoose = new int[] {1, 2};
    private int generatedNumber;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        mapRandomValue = UnityEngine.Random.Range(1, 3);
        generatedNumber = numberToChoose[mapRandomValue];
            
        Debug.Log("Número aleatorio;: " + mapRandomValue + ", número escogido de la lista " + generatedNumber);

        SceneManager.LoadScene(generatedNumber);
        mapRandomValue = UnityEngine.Random.Range(1, 3);
    }
    
}
