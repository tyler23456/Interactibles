using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserTargeting;
using GDA.Interactibles.UserAbility;
using GDA.Interactibles.UserCommand;

namespace GDA.Interactibles.UserAI
{
    [RequireComponent(typeof(Obj), typeof(Targeting), typeof(Command))]
    [RequireComponent(typeof(Ability))]
    public class AI : MonoBehaviour
    {
        Obj obj;
        Targeting targeting;
        Ability ability;
        CommandPool pool;
        AIAnimCallback animCallback;

        // Start is called before the first frame update
        void Start()
        {
            obj = GetComponent<Obj>();
            targeting = GetComponent<Targeting>();
            ability = GetComponent<Ability>();

            pool = new CommandPool(obj, ability, targeting, GetComponents<Command>());
            animCallback = new AIAnimCallback(obj);                
        }

        // Update is called once per frame
        void Update()
        {
            float distance = targeting.GetTargetDistance();
            
            if (pool.commands.Peek().IsDoneOrHasNoDecisionFor(distance))
            {             
                pool.commands.Enqueue(pool.commands.Dequeue());
                pool.commands.Peek().Initialize();
            }
            pool.commands.Peek().Run(obj.anim.ResetVelocity);
            obj.rotation.Interpolate();
        }
    }
}