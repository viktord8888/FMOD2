using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class HealthDisplay : MonoBehaviour {
    [SerializeField] Image fill;

    public void SetPercentage(float value) {
        fill.fillAmount = value;
        // if (fill.fillAmount <= 0.3f && fill.fillAmount >= 0)
        // {
        //     EventInstance health = RuntimeManager.CreateInstance("event:/Heartbeat/Heartbeat");
        //     health.start();
        // }
        //
        // if (fill.fillAmount <= 0.2f && fill.fillAmount >= 0.1f)
        // {
        //     EventInstance lowHealth20 = RuntimeManager.CreateInstance("snapshot:/LowHealth20");
        //     lowHealth20.start();
        // }
        //
        // if (fill.fillAmount <= 0.1f)
        // {
        //     EventInstance lowHealth10 = RuntimeManager.CreateInstance("snapshot:/LowHealth10");
        //     lowHealth10.start();
        // }
    }
}