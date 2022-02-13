using UnityEngine;

namespace GDA.Interactibles.UserObj
{
    [RequireComponent(typeof(Animator), typeof(CharacterController))]
    public class Obj : MonoBehaviour
    {
        Animator animator;
        CharacterController controller;

        [HideInInspector]
        public Events onFoot = new Events();
        [HideInInspector]
        public Events usingSkills = new Events();
        [HideInInspector]
        public Events inWater = new Events();

        public Movement movement;
        public Rotation rotation;
        public Anim anim;

        public bool isGrounded
        {
            get { return controller.isGrounded; }
        }

        public void Reset()
        {
            if (GetComponent<CharacterController>() == null)
                gameObject.AddComponent<CharacterController>();
        }    

        void Start()
        {
            animator = GetComponent<Animator>();
            controller = GetComponent<CharacterController>();

            movement = new Movement(controller);
            rotation = new Rotation(controller);
            anim = new Anim(animator);
        }
    }
}