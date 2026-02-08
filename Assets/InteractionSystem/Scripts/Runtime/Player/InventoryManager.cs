using System.Collections.Generic;
using InteractionSystem.Runtime.Core;
using UnityEngine;

namespace InteractionSystem.Runtime.Player
{
    /// <summary>
    /// Oyuncunun topladýðý eþyalarý yöneten basit envanter sistemi.
    /// </summary>
    public class InventoryManager : MonoBehaviour
    {
        #region Fields

        private List<ItemData> m_CollectedItems = new List<ItemData>();

        #endregion

        #region Methods

        public void AddItem(ItemData item)
        {
            if (item == null) return;

            m_CollectedItems.Add(item);
            Debug.Log($"<color=yellow>[Inventory]</color> Eþya eklendi: {item.ItemName}");
        }

        public bool HasItem(string itemID)
        {
            return m_CollectedItems.Exists(x => x.ItemID == itemID);
        }

        #endregion
    }
}