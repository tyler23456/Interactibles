using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

using GDA.Interactibles.UserStats;
using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserHitText;

namespace GDA.Interactibles.UserHit
{
    [RequireComponent(typeof(Stats))]
    public class Hit : MonoBehaviour
    {
        [SerializeField]
        Color damageTextColor = Color.blue;

        Stats stats;
        Obj animate;
        HitText hitText;
        public void Reset()
        {
            if (GetComponent<Obj>() == null)
                gameObject.AddComponent<Obj>();
        }

        void Start()
        {
            stats = GetComponent<Stats>();
            animate = GetComponent<Obj>();
            hitText = GetComponent<HitText>();
        }

        public void TakeMeleeDamage(float damage, params Action[] damageEvents)
        {
            
            stats.TakeDamage(damage);
            TakeDamage(damage, damageEvents);
        }

        public void TakeProjectileDamage(float damage, params Action[] damageEvents)
        {
            stats.TakeDamage(damage);
            TakeDamage(damage, damageEvents);       
        }

        void TakeDamage(float damage, Action[] damageEvents)
        {
            foreach (Action damageEvent in damageEvents)
                damageEvent();

            if (animate != null)
                animate.anim.Hit();

            if (hitText != null)
                hitText.Show(damage);
        }
    }
}
