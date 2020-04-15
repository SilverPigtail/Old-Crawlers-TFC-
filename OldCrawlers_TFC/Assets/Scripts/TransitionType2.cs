using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionType2 : MonoBehaviour
{
    //public String sceneToLoad;
    private int mapRandomValue;
    private int[] numberToChoose = new int[] {1, 3};
    private int generatedNumber;

    public void OnTriggerEnter2D(Collider2D other)
    {

        mapRandomValue = UnityEngine.Random.Range(2, 3);
        generatedNumber = numberToChoose[mapRandomValue];
            
        Debug.Log("Número aleatorio;: " + mapRandomValue + ", número escogido de la lista " + generatedNumber);

        SceneManager.LoadScene(generatedNumber);
        mapRandomValue = UnityEngine.Random.Range(2, 3);
    }
}
