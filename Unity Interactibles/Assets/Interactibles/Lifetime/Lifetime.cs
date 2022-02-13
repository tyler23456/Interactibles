using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interactibles.UserLifetime
{
    public class Lifetime : MonoBehaviour
    {
        [SerializeField]
        float seconds;

        void Start()
        {
            Destroy(gameObject, seconds);
        }
    }
}