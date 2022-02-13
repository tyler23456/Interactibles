using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interfaces;

namespace GDA.Interactibles.UserSoundSettings
{
    public class SoundSettings : MonoBehaviour, ISoundSettings
    {
        AudioSource music;
        AudioSource ambience;
        AudioSource soundFX; //resources.load

        public int getMusicVolume
        {
            get { return (int)music.volume * 100; }
        }

        public int getAmbienceVolume
        {
            get { return (int)ambience.volume * 100; }
        }

        public int getSoundFXVolume
        {
            get { return (int)soundFX.volume * 100; }
        }

        void Awake()
        {
            music = Instantiate((GameObject)Resources.Load("Sound/MusicSource", typeof(GameObject)), transform).GetComponent<AudioSource>();
            ambience = Instantiate((GameObject)Resources.Load("Sound/AmbienceSource", typeof(GameObject)), transform).GetComponent<AudioSource>();
            soundFX = Instantiate((GameObject)Resources.Load("Sound/SoundFXSource", typeof(GameObject)), transform).GetComponent<AudioSource>();
        }

        public void SetMusicVolume(float value)
        {
            music.volume = value / 100f;
        }

        public void SetAmbienceVolume(float value)
        {
            ambience.volume = value / 100f;
        }

        public void SetSFXVolume(float value)
        {
            soundFX.volume = value / 100f;
        }
    }
}