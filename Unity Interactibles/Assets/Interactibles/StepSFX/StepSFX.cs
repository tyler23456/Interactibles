using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserSoundFX;
using GDA.Interactibles.UserAssetPool;

public class StepSFX : MonoBehaviour
{
    SoundFX sound;
    AssetPool bank;

    float minPitch = 0.8f;
    float maxPitch = 1.2f;
    float minVolume = 0.005f;
    float maxVolume = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<SoundFX>();
        bank = Camera.main.gameObject.GetComponent<AssetPool>();
    }

    void WalkLeftStepEvent()
    {
        sound.Play(bank.leftWalkSteps, minPitch, maxPitch, minVolume, maxVolume);
    }

    void WalkRightStepEvent()
    {
        sound.Play(bank.rightWalkSteps, minPitch, maxPitch, minVolume, maxVolume);
    }

    void SprintLeftStepEvent()
    {
        sound.Play(bank.leftSprintSteps, minPitch, maxPitch, minVolume, maxVolume);
    }

    void SprintRightStepEvent()
    {
        sound.Play(bank.rightSprintSteps, minPitch, maxPitch, minVolume, maxVolume);
    } 
}
