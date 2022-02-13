using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using GDA.Interfaces;

namespace GDA.Interactibles.UserAssetPool
{
    public class AssetPool : MonoBehaviour, IAssetPool
    {
        public Dictionary<string, GameObject> abilities { get; private set; }
        public Dictionary<string, GameObject> hitFX { get; private set; }

        public GameObject[] players { get; private set; }
        public GameObject[] spawners { get; private set; }

        public AudioClip[] leftWalkSteps { get; private set; }
        public AudioClip[] rightWalkSteps { get; private set; }
        public AudioClip[] leftSprintSteps { get; private set; }
        public AudioClip[] rightSprintSteps { get; private set; }

        public AudioClip[] meleeHits { get; private set; }
        public AudioClip[] abilityHits { get; private set; }

        public Dictionary<string, AudioClip> menuFX { get; private set; }


        // Start is called before the first frame update
        void Awake()
        {
            UnityEngine.Object[] objects;
            AudioClip[] clips;

            objects = Resources.LoadAll("Abilites", typeof(GameObject));
            foreach (Object obj in objects)
                abilities.Add(obj.name, (GameObject)obj);

            objects = Resources.LoadAll("HitFX", typeof(GameObject));
            foreach (Object obj in objects)
                hitFX.Add(obj.name, (GameObject)obj);

            players = new GameObject[1] { GameObject.Find("aj") }; //temporary

            spawners = GameObject.Find("Gaia Tools").transform.Find("Gaia Game Object Spawns").transform.Find("Spawners")
                .Cast<Transform>().ToArray().Select(spawner => spawner.gameObject).ToArray();

            objects = Resources.LoadAll("Footsteps/Walk/Left", typeof(AudioClip));
            leftWalkSteps = objects.Select(step => (AudioClip)step).ToArray();

            objects = Resources.LoadAll("Footsteps/Walk/Right", typeof(AudioClip));
            rightWalkSteps = objects.Select(step => (AudioClip)step).ToArray();

            objects = Resources.LoadAll("Footsteps/Sprint/Left", typeof(AudioClip));
            leftSprintSteps = objects.Select(step => (AudioClip)step).ToArray();

            objects = Resources.LoadAll("Footsteps/Sprint/Right", typeof(AudioClip));
            rightSprintSteps = objects.Select(step => (AudioClip)step).ToArray();

            menuFX = new Dictionary<string, AudioClip>();
            objects = Resources.LoadAll("MenuFX", typeof(AudioClip));
            foreach (Object obj in objects)
                menuFX.Add(obj.name,(AudioClip)obj);
        }
    }
}