using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using GDA.Interactibles.UserMelee;
using GDA.Interactibles.UserAbility;

namespace GDA.Interactibles.UserTargeting
{
    public class Targeting : MonoBehaviour
    {
        [SerializeField]
        public Collider target;

        void Start()
        {
            target = GameObject.FindWithTag("allie").GetComponent<Collider>();
        }

        public Collider GetTarget()
        {
            return target;
        }

        Collider[] GetNearbyEnemies(float forwardOffset, float radius)
        {
            string layerName = gameObject.layer == 10 ? "Allie" : "Enemy";
            return Physics.OverlapSphere(transform.position + (transform.forward * forwardOffset), radius, LayerMask.GetMask(layerName));
        }

        public void ToNearbyEnemies(float forwardOffset, float radius, params Action<Collider>[] enemyEvents)
        {
            Collider[] enemies = GetNearbyEnemies(forwardOffset, radius);
            foreach (Collider enemy in enemies)
                foreach (Action<Collider> enemyEvent in enemyEvents)
                    enemyEvent(enemy);
        }

        public float GetTargetDistance()
        {
            return Vector3.Distance(this.transform.position, target.transform.position);
        }

        public Vector3 GetDirectionToTarget()
        {
            return (target.transform.position - this.transform.position).normalized;
        }
    }
}