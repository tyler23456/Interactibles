using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GDA.Interfaces
{
    public interface IInventorySettings
    {
        IItem[] getSelected { get; }
        IItem[] getUnselected { get; }
    }
}