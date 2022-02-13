using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using GDA.Interactibles.UserLifetime;
using GDA.Interactibles.UserTargeting;
using GDA.Interactibles.UserHit;

namespace GDA.Interactibles.UserProjectile
{
    [RequireComponent(typeof(Targeting), typeof(Lifetime))]
    public class Projectile : MonoBehaviour
    {
        [SerializeField]
        float lifeTime = 5f;
        [SerializeField]
        float checkRate = 0.5f;

        [SerializeField]
        float damage = 19;

        Targeting targeting;

        void Start()
        {
            targeting = GetComponent<Targeting>();
        }

        void DamageEnemy(Collider enemy)
        {
            Hit enemyHit = enemy.GetComponent<Hit>();

            if (enemyHit != null)
                enemyHit.TakeProjectileDamage(damage);
        }

        void Update()
        {
            if (targeting.GetTarget() != null)
            {
                //checkRate += Time.deltaTime;
                if (checkRate == 0.5f)
                {
                    //mover.ResetVelocity();
                    //mover.Accelerate(targeting.GetDirectionToTarget(), 10);
                    //checkRate = 0f;
                }
            }
            //mover.Move();

            targeting.ToNearbyEnemies(0, 2, DamageEnemy);
        }
    }
}