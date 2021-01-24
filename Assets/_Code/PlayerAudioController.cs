using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerAudioController : PlayerSubsystem
{

    public override void HandleEvent(PlayerEventType eventType) {
        switch (eventType) {
            case PlayerEventType.Jump:
                EventInstance jump = RuntimeManager.CreateInstance("event:/Player/Jump");
                jump.start();
                break;
            case PlayerEventType.Landing:
                EventInstance land = RuntimeManager.CreateInstance("event:/Player/Land");
                land.start();
                break;
            case PlayerEventType.Death:
                EventInstance death = RuntimeManager.CreateInstance("event:/Player/Death");
                death.start();
                break;
            case PlayerEventType.Attack:
                EventInstance attack = RuntimeManager.CreateInstance("event:/Player/Attack");
                attack.start();
                break;
            case PlayerEventType.Footstep:
                EventInstance walk = RuntimeManager.CreateInstance("event:/Player/Walk");
                walk.start();
                break;
        }
    }
}
