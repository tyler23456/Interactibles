using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace GDA.Interactibles.UserObj
{
    public class Movement
    {
        CharacterController controller;
        Animator animator;
        public readonly static Vector3 gravity = new Vector3(0, -9.8f, 0);
        protected Vector3 rotation = Vector3.forward;      

        public Movement(CharacterController controller)
        {
            this.controller = controller;
        }

        public void AccelerateAtRandom(params Action[] moveEvents)
        {
            int randomX = UnityEngine.Random.Range(-1, 2);
            int randomY = UnityEngine.Random.Range(-1, 2);
        }

        public void Jump(bool isGrounded, params Action[] moveEvents)
        {
            if (isGrounded)
                foreach (Action moveEvent in moveEvents)
                    moveEvent();
        }

        public void AddGravity()
        {
            controller.Move(gravity * Time.deltaTime);
        }

        public void Forward(float speed)
        {
            controller.Move(controller.transform.forward * speed);
        }
    }
}
