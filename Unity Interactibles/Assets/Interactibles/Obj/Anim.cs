using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interactibles.UserObj
{
    public class Anim
    {
        Animator animator;
        Vector2 velocity;

        public Vector2 getVelocity
        {
            get { return velocity; }
        }

        public Anim(Animator animator)
        {
            this.animator = animator;
        }
        
        public void Jump()
        {
            animator.SetTrigger("isJump");
        }

        public void Melee()
        {
            animator.SetTrigger("isMelee");
        }

        public void Ability()
        {
            animator.SetTrigger("isAbility");
        }

        public void Hit()
        {
            animator.SetTrigger("isHit");
        }

        public void ToggleAiming()
        {
            animator.SetBool("isAiming", !animator.GetBool("isAiming"));
        }

        public void SetBool(string name, bool isActive)
        {
            animator.SetBool(name, isActive);
        }

        public void SetState(State state)
        {
            animator.SetInteger("state", (int)state);
        }

        public void Aim(float aimX, float aimY)
        {
            animator.SetFloat("aimX", aimX, 1f, Time.deltaTime);
            animator.SetFloat("aimY", aimY, 1f, Time.deltaTime);
        }

        public void Velocity(float velocityX, float velocityZ)
        {
            this.velocity.x = velocityX;
            this.velocity.y = velocityZ;
            animator.SetFloat("velocityX", Mathf.Abs(velocityX));
            animator.SetFloat("velocityZ", Mathf.Abs(velocityZ));
        }

        public void ResetVelocity()
        {
            this.velocity.x = 0f;
            this.velocity.y = 0f;
            animator.SetFloat("velocityX", 0f);
            animator.SetFloat("velocityZ", 0f);
        }

        public enum State
        {
            onFoot = 0,
            climb = 1,
            inWater = 2
        }
    }
}
