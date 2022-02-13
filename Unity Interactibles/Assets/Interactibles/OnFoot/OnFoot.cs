using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserOnFoot
{
    public class OnFoot : StateMachineBehaviour
    {
        Obj animate;

        void Awake()
        {
            
        }

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate = animator.gameObject.GetComponent<Obj>();
            animate.onFoot.Start();
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate.onFoot.Stay();
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animate.onFoot.Stop();
        }
    }
}