using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/***
 * This script allows the program to change the volume using the audio mixer tool in Unity.
 */
public class SettingsMenu : MonoBehaviour
{
    /**
     * aMixer -> AudioMixer parameter that interacts with the volume in Unity
     */
    public AudioMixer aMixer;
    
    /**
     * This function set the volume based on the audioMixer settings in Unity.
     */
    public void ChangeVolume(float volume)
    {
        aMixer.SetFloat("Volume", volume);
        
        
    }
}
