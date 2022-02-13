using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GDA.Interfaces;
using GDA.Interactibles.UserInventorySettings;

namespace GDA.Interactibles.UserInventory
{
    [RequireComponent(typeof(InventorySettings))]
    public class Inventory : MonoBehaviour
    {
        InventorySettings inventorySettings;

        void Start()
        {
            inventorySettings = GetComponent<InventorySettings>();
        }

        void Update()
        {

        }
    }
}