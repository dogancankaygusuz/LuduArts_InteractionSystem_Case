using InteractionSystem.Runtime.Core;
using InteractionSystem.Runtime.Player;
using UnityEngine;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Basýlý tutarak açýlan ve içinden eþya çýkan sandýk sýnýfý.
    /// </summary>
    public class Chest : HoldInteractable
    {
        #region Fields

        [Header("Chest Content")]
        [SerializeField] private ItemData m_StoredItem;
        [SerializeField] private bool m_IsOpened = false;

        #endregion

        #region Methods

        public override void InteractComplete()
        {
            if (m_IsOpened) return;

            m_IsOpened = true;

            if (m_StoredItem != null)
            {
                InventoryManager inventory = Object.FindFirstObjectByType<InventoryManager>();
                if (inventory != null)
                {
                    inventory.AddItem(m_StoredItem);
                    Debug.Log($"<color=green>[Chest]</color> Sandýktan {m_StoredItem.ItemName} çýktý!");
                }
            }

            base.InteractComplete();
        }

        // Açýlmýþ sandýk hover edilmesin
        public override void OnHoverEnter()
        {
            if (!m_IsOpened) base.OnHoverEnter();
        }

        #endregion
    }
}