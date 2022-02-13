using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserAbility;
using GDA.Interactibles.UserTargeting;
using GDA.Interactibles.UserCommand;

namespace GDA.Interactibles.UserAI
{
    class CommandPool
    {
        Obj obj;
        Ability ability;
        Targeting targeting;

        Dictionary<string, Action> pool;
        public Queue<Command> commands = new Queue<Command>();

        public CommandPool(Obj obj, Ability ability, Targeting targeting, Command[] commandComponents)
        {
            pool = new Dictionary<string, Action>();
            pool.Add("peaceful", () => obj.movement.AccelerateAtRandom());
            pool.Add("walkTo", () => obj.anim.Velocity(0, 1));
            pool.Add("walkFrom", () => obj.anim.Velocity(0, -1));
            pool.Add("walkLeft", () => obj.anim.Velocity(-1, 0));
            pool.Add("walkRight", () => obj.anim.Velocity(1, 0));
            pool.Add("sprintTo", () => obj.anim.Velocity(0, 2));
            pool.Add("sprintFrom", () => obj.anim.Velocity(0, -2));
            pool.Add("sprintLeft", () => obj.anim.Velocity(-2, 0));
            pool.Add("sprintRight", () => obj.anim.Velocity(2, 0));
            pool.Add("melee", () => obj.anim.Melee());
            pool.Add("darkSeeker", () => ability.Use("IceBlast", 1, () => obj.rotation.RotateYAxisTo(targeting.GetDirectionToTarget())));




            foreach (Command decision in commandComponents)
            {
                decision.Set(pool[decision.getName]);
                commands.Enqueue(decision);
            }
        }
    }
}