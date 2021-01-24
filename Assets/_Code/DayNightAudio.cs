using System;
using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class DayNightAudio : MonoBehaviour
{
    
    TimeOfDay timeOfDay;

    private void Start()
    {
        DayNightSound();
    }

    private void DayNightSound()
    {
        if (timeOfDay == TimeOfDay.Day)
        {
            Debug.Log("Day");
            EventInstance day = RuntimeManager.CreateInstance("snapshot:/Day");
            day.start();
        }
        if (timeOfDay == TimeOfDay.Night)
        {
            Debug.Log("Night");
            EventInstance night = RuntimeManager.CreateInstance("snapshot:/Night");
            night.start();
        }
        if (timeOfDay == TimeOfDay.Sunset)
        {
            Debug.Log("Sunset");
            EventInstance sunset = RuntimeManager.CreateInstance("snapshot:/Sunset");
            sunset.start();
        }
    }
}
