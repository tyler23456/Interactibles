using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

using GDA.Interactibles.UserObj;
using GDA.Interactibles.UserAbility;
using GDA.Interactibles.UserInventorySettings;
using GDA.Interfaces;

namespace GDA.Interactibles.UserControls
{
    class CommandManager
    {
        Obj obj;
        Ability ability;
        IInventorySettings inventorySettings;
        int maxCombination;
        int currentCombination;
        bool isMelee;

        public Action UseCurrentCommand { get; private set; }

        public CommandManager(Obj obj, Ability ability, IInventorySettings inventorySettings)
        {
            this.obj = obj;
            this.ability = ability;
            this.inventorySettings = inventorySettings;
            maxCombination = 3;
            currentCombination = 0;
            UseCurrentCommand = UseMelee;
            isMelee = true;
        }

        void UseMelee()
        {
            obj.anim.Melee();   
        }

        void UseAbility()
        {
            int level = 0;
            string name = inventorySettings.getSelected[currentCombination * maxCombination].name;

            for (int i = currentCombination * maxCombination; i < (currentCombination + 1) * maxCombination; i++)
                if (inventorySettings.getSelected[i].name == name)
                    level++;

            if (name != "blank")
                ability.Use(name, level);
        }

        public void ToggleCommand()
        {
            isMelee = !isMelee;

            if (isMelee)
                UseCurrentCommand = UseMelee;
            else
                UseCurrentCommand = UseAbility;
        }

        public void ScrollAbilities()
        {
            currentCombination = currentCombination % 3;
        }
    }
}