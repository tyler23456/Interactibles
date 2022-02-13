using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interactibles.UserObj
{
    public class Rotation
    {
        CharacterController controller;
        protected Vector3 rotation = Vector3.forward;

        public Vector3 getRotation
        {
            get { return rotation; }
        }

        public Rotation(CharacterController controller)
        {
            this.controller = controller;
        }

        public void YAxisTo(Vector3 startingRotation, Vector3 offsetRotation)
        {

            rotation = startingRotation;
            Vector3 newRotation = Quaternion.LookRotation(offsetRotation).eulerAngles;
            rotation += newRotation;
            rotation.x = 0;
            rotation.z = 0;
            //Interpolate();
        }

        public void RotateYAxisTo(Vector3 offsetRotation)
        {

            rotation = Vector3.zero;
            Vector3 newRotation = Quaternion.LookRotation(offsetRotation).eulerAngles;
            rotation += newRotation;
            rotation.x = 0;
            rotation.z = 0;
            //Interpolate();
        }

        public void RotateXAndYAxesTo(Vector3 startingRotation, Vector3 offsetRotation)
        {
            rotation = startingRotation;
            Vector3 newRotation = Quaternion.LookRotation(offsetRotation).eulerAngles;
            rotation += newRotation;
            //Interpolate();
        }

        public void RotateXAndYAxesTo(Vector3 yAxisFacingDirection)
        {
            rotation = controller.transform.rotation.eulerAngles;
            Vector3 newRotation = Quaternion.LookRotation(yAxisFacingDirection).eulerAngles;
            rotation = newRotation;
            //Interpolate();
        }

        public void Interpolate()
        {
            controller.transform.rotation = Quaternion.Lerp(controller.transform.rotation, Quaternion.Euler(rotation), 0.15f * 60f * Time.deltaTime);
        }
    }
}