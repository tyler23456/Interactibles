using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserClimber
{
    [RequireComponent(typeof(Obj))]
    public class Climber : MonoBehaviour
    {
        Obj animate;

        // Start is called before the first frame update
        void Start()
        {
            animate = GetComponent<Obj>();
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}