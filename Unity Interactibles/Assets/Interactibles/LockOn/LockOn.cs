using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interactibles.UserLockOn
{
    public class LockOn : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField]
        Vector3 position;
        Vector3 direction = Vector3.zero;

        public Vector3 getDirection
        {
            get { return direction; }
        }

        // Update is called once per frame
        void Update()
        {
            direction = Camera.main.ScreenPointToRay(position).direction;
        }
    }
}