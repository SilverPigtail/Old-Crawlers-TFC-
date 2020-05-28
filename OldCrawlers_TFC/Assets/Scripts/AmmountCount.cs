using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmountCount : MonoBehaviour
{
    private int count;
    public StageCount stageCount;
    
    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        stageCount = GetComponent<StageCount>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        count += 1;
       // Debug.Log("Contador: " + count.ToString());
       
    }
}
