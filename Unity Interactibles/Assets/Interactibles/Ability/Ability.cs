using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using GDA.Interactibles.UserStats;
using GDA.Interactibles.UserTargeting;
using GDA.Interactibles.UserProjectile;
using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserLockOn;

namespace GDA.Interactibles.UserAbility
{
    [RequireComponent(typeof(Obj))]
    public class Ability : MonoBehaviour
    {
        Obj animate;
        LockOn lockOn;

        GameObject obj;
        Vector3 position;
        Quaternion rotation;

        private void Reset()
        {
            if (GetComponent<Stats>() == null)
                gameObject.AddComponent<Stats>();
            if (GetComponent<Obj>() == null)
                gameObject.AddComponent<Obj>();
        }

        void Start()
        {
            animate = GetComponent<Obj>();
            lockOn = GetComponent<LockOn>();
        }

        public void Use(string abilityName, int abilityLevel, params Action[] actions)
        {          
            obj = Resources.Load<GameObject>("Abilities/" + abilityName + abilityLevel.ToString());

            if (obj == null)
                return;

            if (animate != null)
                animate.anim.Ability();
            else
                RangedAnimationEvent();

            foreach (Action action in actions)
                action();
        }

        void RangedAnimationEvent()
        {
            position = transform.position + obj.transform.position;

            if (lockOn == null)
                rotation = transform.rotation;
            else
                rotation = transform.rotation;
            //rotation = Quaternion.LookRotation(lockOn.getDirection);

            Instantiate(obj, position, rotation);
        }
    }
}