using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer aMixer;
    public KeepVolume keepVolume;

    public void Start()
    {
        /*keepVolume = GetComponent<KeepVolume>();
        aMixer.SetFloat("Volume", PlayerPrefs.GetFloat("TrackVolume"));*/
    }

    public void ChangeVolume(float volume)
    {
        aMixer.SetFloat("Volume", volume);
        
        //PlayerPrefs.SetFloat("TrackVolume", volume);
        
    }
}
