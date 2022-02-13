using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface IControlSettings
    {
        KeyCode forward { get; }
        KeyCode back { get; }
        KeyCode left { get; }
        KeyCode right { get; }
        KeyCode sprint { get; }
        KeyCode jump { get; }
        KeyCode attack { get; }
        KeyCode toggleAbility { get; }
        KeyCode scrollAbilities { get; }
        KeyCode toggleMenu { get; }

        public void SetForward(int value);
        public void SetBack(int value);
        public void SetLeft(int value);
        public void SetRight(int value);
        public void SetSprint(int value);
        public void SetJump(int value);
        public void SetAttack(int value);
        public void SetToggleAbility(int value);
        public void SetScrollAbilities(int value);
        public void SetToggleMenu(int value);
    }
}