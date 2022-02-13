using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interfaces;

namespace GDA.Interactibles.UserControlSettings
{
    public class ControlSettings : MonoBehaviour, IControlSettings
    {
        public KeyCode forward { get; set; } = KeyCode.W;
        public KeyCode back { get; set; } = KeyCode.S;
        public KeyCode left { get; set; } = KeyCode.A;
        public KeyCode right { get; set; } = KeyCode.D;
        public KeyCode sprint { get; set; } = KeyCode.LeftShift;
        public KeyCode jump { get; set; } = KeyCode.Space;
        public KeyCode attack { get; set; } = KeyCode.Mouse0;
        public KeyCode toggleAbility { get; set; } = KeyCode.Mouse1;
        public KeyCode scrollAbilities { get; set; } = KeyCode.Mouse2;
        public KeyCode toggleMenu { get; set; } = KeyCode.Escape;

        void Start()
        {
        }

        public void SetForward(int value)
        {
            forward = (KeyCode)value;
        }

        public void SetBack(int value)
        {
            back = (KeyCode)value;
        }

        public void SetLeft(int value)
        {
            left = (KeyCode)value;
        }

        public void SetRight(int value)
        {
            right = (KeyCode)value;
        }

        public void SetSprint(int value)
        {
            sprint = (KeyCode)value;
        }

        public void SetJump(int value)
        {
            jump = (KeyCode)value;
        }

        public void SetAttack(int value)
        {
            attack = (KeyCode)value;
        }

        public void SetToggleAbility(int value)
        {
            toggleAbility = (KeyCode)value;
        }

        public void SetScrollAbilities(int value)
        {
            scrollAbilities = (KeyCode)value;
        }

        public void SetToggleMenu(int value)
        {
            toggleMenu = (KeyCode)value;
        }
    }
}