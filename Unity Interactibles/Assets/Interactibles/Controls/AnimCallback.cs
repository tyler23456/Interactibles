using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserControls
{
    public class AnimCallback
    {
        Obj obj;

        public AnimCallback(Obj obj)
        {
            this.obj = obj;
            obj.onFoot.Stay = () => { FaceDirectionOfCamera(); obj.movement.AddGravity(); };
            obj.usingSkills.Stay = () => { obj.rotation.RotateYAxisTo(Camera.main.transform.forward); obj.movement.AddGravity(); };
            obj.inWater.Stay = () => { FaceDirectionOfCamera3D(); };
        }

        void FaceDirectionOfCamera()
        {
            Vector2 velocity = obj.anim.getVelocity;
            Vector3 direction = new Vector3(velocity.x, 0f, velocity.y).normalized;
            obj.rotation.YAxisTo(Camera.main.transform.rotation.eulerAngles, direction);
        }

        void FaceDirectionOfCamera3D()
        {
            Vector2 velocity = obj.anim.getVelocity;
            Vector3 direction = new Vector3(velocity.x, 0f, velocity.y).normalized;
            obj.rotation.RotateXAndYAxesTo(Camera.main.transform.rotation.eulerAngles, direction);
        }
    }
}
