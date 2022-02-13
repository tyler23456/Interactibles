using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface ISoundFX
    {
        public void Play(AudioClip clip, float minPitch = 1f, float maxPitch = 1f, float minVolume = 1f, float maxVolume = 1f);
        public void Play(AudioClip[] clips, float minPitch = 1f, float maxPitch = 1f, float minVolume = 1f, float maxVolume = 1f);
    }
}