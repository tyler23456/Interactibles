using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interfaces;

namespace GDA.Interactibles.UserSoundFX
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundFX : MonoBehaviour, ISoundFX
    {
        AudioSource source;
        AudioClip clip;

        void Start()
        {
            source = GetComponent<AudioSource>();
        }

        public void Play(AudioClip clip, float minPitch = 1f, float maxPitch = 1f, float minVolume = 1f, float maxVolume = 1f)
        {
            source.pitch = UnityEngine.Random.Range(minPitch, maxPitch);
            source.volume = UnityEngine.Random.Range(minVolume, maxVolume);
            source.PlayOneShot(clip);
        }

        public void Play(AudioClip[] clips, float minPitch = 1f, float maxPitch = 1f, float minVolume = 1f, float maxVolume = 1f)
        {
            clip = clips[UnityEngine.Random.Range(0, clips.Length)];

            if (clip != null)
                Play(clip, minPitch, maxPitch, minVolume, maxVolume);
        }

    }
}