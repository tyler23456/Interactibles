using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface ISoundSettings
    {
        int getMusicVolume { get; }
        int getAmbienceVolume { get; }
        int getSoundFXVolume { get; }

        void SetMusicVolume(float value);
        void SetAmbienceVolume(float value);
        void SetSFXVolume(float value);
    }
}