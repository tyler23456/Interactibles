using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interfaces;

namespace GDA.Interactibles.UserItem
{
    public class Item : IItem
    {
        public string name { get; private set; }
        public int count { get; private set; }

        public bool isEmpty
        {
            get { return name == "Blank"; }
        }

        public Item()
        {
            this.name = "Blank";
            this.count = 0;
        }

        public Item(string name, int count)
        {
            this.name = name;
            this.count = count;
        }

        public void SetCount(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
    }
}