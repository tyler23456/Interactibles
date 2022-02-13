using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interactibles.UserSpawner
{
    public class Spawner : MonoBehaviour
    {
        float accumulator = 0;
        [SerializeField]
        float spawnFrequency = 10f;
        [SerializeField]
        int maximumSpawnables = 3;
        [SerializeField]
        List<Spawnable> spawnables;
        List<GameObject> spawned = new List<GameObject>();

        float totalWeight = 0;
        List<(float max, int index)> ranges = new List<(float, int)> { };

        private void Start()
        {
            int i = 0;
            foreach (Spawnable spawnable in spawnables)
            {
                totalWeight += spawnable.settings.weight;
                ranges.Add((totalWeight, i));
                i++;
            }              
        }

        void Update()
        {
            accumulator += Time.deltaTime;          

            if (accumulator >= spawnFrequency && spawned.Count < maximumSpawnables)
            {
                //float weight = UnityEngine.Random.Range(0f, totalWeight);
                //foreach ((float max, int index) range in ranges)
                //    if (weight <= range.max)
                //        spawned.Add(Instantiate(spawnables[range.index].obj, transform));
                //accumulator = 0;
            }
        }

        void LateUpdate()
        {
            for (int i = 0; i < spawned.Count; i++)
                if (spawned[i] == null)
                {
                    spawned.RemoveAt(i);
                    i--;
                }
        }
    }
}