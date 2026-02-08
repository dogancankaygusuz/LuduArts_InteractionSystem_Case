using InteractionSystem.Runtime.Core;
using InteractionSystem.Runtime.Player;
using UnityEngine;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Dünyadan toplanabilen anahtar nesnesi.
    /// </summary>
    public class KeyPickup : InteractableBase
    {
        #region Fields

        [Header("Key Settings")]
        [SerializeField] private ItemData m_KeyData;

        #endregion

        #region Methods

        public override void OnInteract()
        {

            InventoryManager inventory = Object.FindFirstObjectByType<InventoryManager>();

            if (inventory != null && m_KeyData != null)
            {
                inventory.AddItem(m_KeyData);
                Debug.Log($"<color=green>[Pickup]</color> {m_KeyData.ItemName} toplandý.");
                gameObject.SetActive(false);
            }
            else
                Debug.LogWarning($"[{nameof(KeyPickup)}] Envanter veya KeyData eksik!");
        }

        #endregion
    }
}