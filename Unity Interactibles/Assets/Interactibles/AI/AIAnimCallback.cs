using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interactibles.UserObj;

namespace GDA.Interactibles.UserAI
{
    class AIAnimCallback
    {
        Obj obj;  

        public AIAnimCallback(Obj obj)
        {
            this.obj = obj;
            obj.anim.ToggleAiming();
            obj.onFoot.Stay = () => { obj.rotation.RotateYAxisTo(Camera.main.transform.forward); obj.movement.AddGravity(); };
            obj.usingSkills.Stay = () => { obj.rotation.RotateYAxisTo(Camera.main.transform.forward); obj.movement.AddGravity(); };
        }
    }
}