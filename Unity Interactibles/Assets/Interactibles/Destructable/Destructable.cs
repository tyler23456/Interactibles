using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserStats;

namespace GDA.Interactibles.UserDestructible
{
    [RequireComponent(typeof(Stats))]
    public class Destructable : MonoBehaviour
    {
        GameObject impact;
        Stats stats;

        public void Reset()
        {
            if (GetComponent<Stats>() == null)
                gameObject.AddComponent<Stats>();
        }

        void Start()
        {
            stats = GetComponent<Stats>();
        }

        void Update()
        {
            if (stats.health < 0)
            {
                if (impact != null)
                    Instantiate(impact);
                Destroy(gameObject);
            }

        }

        public void AddDependancies()
        {

        }
    }
}