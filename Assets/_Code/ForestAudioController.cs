using System;
using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;

public class ForestAudioController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Forest"))
        {
            Debug.Log("entered");
            EventInstance forest = RuntimeManager.CreateInstance("snapshot:/Forest");
            forest.start();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Forest"))
        {
            Debug.Log("left");
            EventInstance outsideForest = RuntimeManager.CreateInstance("snapshot:/OutsideForest");
            outsideForest.start();
        }
        
    }
}
