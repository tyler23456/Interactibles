using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserInWater
{
    public class InWater : StateMachineBehaviour
    {
        Obj animate;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate = animator.gameObject.GetComponent<Obj>();
            animate.inWater.Start();
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

            animate.inWater.Stay();
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate.inWater.Stop();
        }
    }
}