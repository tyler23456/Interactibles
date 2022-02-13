using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interfaces;
using GDA.Interactibles.UserItem;

namespace GDA.Interactibles.UserInventorySettings
{
    public class InventorySettings : MonoBehaviour, IInventorySettings
    {
        IItem[] selected;
        IItem[] unselected;

        void Start()
        {
            selected = new Item[9];

            for (int i = 0; i < selected.Length; i++)
                selected[i] = new Item();

            unselected = new Item[24];

            for (int i = 0; i < unselected.Length; i++)
                unselected[i] = new Item();

            unselected[0] = new Item("HighJump", 4);
            unselected[1] = new Item("Shield", 1);
            unselected[2] = new Item("Platform", 2);
            unselected[3] = new Item("HighJump", 4);
            unselected[4] = new Item("Shield", 9);
            unselected[5] = new Item("Platform", 6);
        }

        public IItem[] getSelected
        {
            get { return selected; }
        }

        public IItem[] getUnselected
        {
            get { return unselected; }
        }
    }
}