using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/***
 * This script allows the program to keep the music when the scene changes.
 */
public class AudioKeeper : MonoBehaviour
{
 
    /***
     * This function executes when the scene loads. This keeps the volume when a scene is changed.
     */
    public void Start()
    {

        DontDestroyOnLoad(transform.gameObject);
    }
}
