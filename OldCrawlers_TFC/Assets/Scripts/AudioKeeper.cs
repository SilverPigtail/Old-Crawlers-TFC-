using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioKeeper : MonoBehaviour
{
 
    public void Start()
    {

        DontDestroyOnLoad(transform.gameObject);
    }
}
