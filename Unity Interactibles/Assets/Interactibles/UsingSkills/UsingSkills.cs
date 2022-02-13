using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserObj
{
    public class UsingSkills : StateMachineBehaviour
    {
        Obj animate;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate = animator.gameObject.GetComponent<Obj>();
            animate.usingSkills.Start();
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate.usingSkills.Stay();
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate.usingSkills.Stop();
        }
    }
}