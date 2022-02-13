using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface IItem
    {
        string name { get; }
        int count { get; }

        bool isEmpty { get; }

        void SetCount(string name, int count);
    }
}