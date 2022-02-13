using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using FirstGearGames.SmoothCameraShaker;

using GDA.Interactibles.UserStats;
using GDA.Interactibles.UserHit;
using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserTargeting;
using GDA.Interactibles.UserHitText;

namespace GDA.Interactibles.UserMelee
{
    [RequireComponent(typeof(Stats), typeof(Targeting), typeof(AudioSource))]
    public class Melee : MonoBehaviour
    {
        [SerializeField]
        protected float offset = 0;
        [SerializeField]
        protected float radius = 0.5f;

        Stats stats;
        Targeting targeting;
        AudioSource userAudio;
        ShakeData shakeData;

        public void Reset()
        {
            if (GetComponent<Hit>() == null)
                gameObject.AddComponent<Hit>();
        }

        void Start()
        {
            stats = GetComponent<Stats>();
            targeting = GetComponent<Targeting>();
            userAudio = GetComponent<AudioSource>();
            shakeData = (ShakeData)Resources.Load("Shakers/Hit1", typeof(ShakeData));
        }

        void DamageEnemy(Collider enemy)
        {
            Instantiate(Resources.Load("Hits/White1", typeof(GameObject)), enemy.ClosestPointOnBounds(transform.position + Vector3.up * 1.5f), Quaternion.identity);
            userAudio.volume = 0.2f;
            userAudio.pitch = UnityEngine.Random.Range(0.7f, 1.3f);
            userAudio.PlayOneShot((AudioClip)Resources.Load("HitFX/Hit1"));
            CameraShakerHandler.Shake(shakeData);

            Hit enemyHit = enemy.GetComponent<Hit>();

            if (enemyHit != null)
                enemyHit.TakeMeleeDamage(this.stats.getStrength);
        }

        public void MeleeContactEvent()
        {
            targeting.ToNearbyEnemies(offset, radius, DamageEnemy);
        }
    }
}