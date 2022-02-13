using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserSwimmer
{
    [RequireComponent(typeof(Obj))]
    public class Swimmer : MonoBehaviour
    {
        Obj animate;
        float baseSpeed = 5f;

        void Start()
        {
            animate = GetComponent<Obj>();        
        }

        void Update()
        {
            if (transform.position.y < 25f)
            {
                animate.anim.SetState(Anim.State.inWater);
                if (Input.GetKey(KeyCode.W))
                    animate.movement.Forward(baseSpeed * Time.deltaTime);
                else if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.LeftShift))
                    animate.movement.Forward(baseSpeed * 2 * Time.deltaTime);
            }
            else if (transform.position.y >= 25f)
            {
                animate.anim.SetState(Anim.State.onFoot);
            }
        }
    }
}

