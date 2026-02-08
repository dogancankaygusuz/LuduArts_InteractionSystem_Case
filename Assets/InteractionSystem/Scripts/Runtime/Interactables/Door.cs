using InteractionSystem.Runtime.Core;
using InteractionSystem.Runtime.Player;
using UnityEngine;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Toggle sistemini kullanarak açýlýp kapanan kapý sýnýfý.
    /// </summary>
    public class Door : ToggleInteractable
    {
        #region Fields

        [Header("Door Animation")]
        [SerializeField] private Transform m_DoorVisual;
        [SerializeField] private Vector3 m_OpenRotation = new Vector3(0, 90, 0);
        [SerializeField] private Vector3 m_ClosedRotation = Vector3.zero;
        [SerializeField] private float m_SmoothSpeed = 5f;

        [Header("Lock Settings")]
        [SerializeField] private bool m_IsLocked = false;
        [SerializeField] private ItemData m_RequiredKey;
        [SerializeField] private string m_LockedMessage = "Locked - Key Required";

        #endregion

        #region Unity Methods

        private void Update()
        {
            // Kapýyý yumuþak bir þekilde döndür
            Vector3 targetRotation = m_IsToggled ? m_OpenRotation : m_ClosedRotation;
            m_DoorVisual.localRotation = Quaternion.Slerp(
                m_DoorVisual.localRotation,
                Quaternion.Euler(targetRotation),
                Time.deltaTime * m_SmoothSpeed
            );
        }
        public override void OnInteract()
        {
            if (m_IsLocked)
            {
                // 1. Güvenlik Kontrolü: Gereken anahtar atanmýþ mý?
                if (m_RequiredKey == null)
                {
                    Debug.LogError($"[{nameof(Door)}] {gameObject.name} kilitli iþaretlenmiþ ama 'Required Key' atanmamýþ!");
                    return;
                }

                // 2. Güvenlik Kontrolü: Envanter sahnede var mý?
                InventoryManager inventory = FindObjectOfType<InventoryManager>();
                if (inventory == null)
                {
                    Debug.LogError($"[{nameof(Door)}] Sahnede InventoryManager bulunamadý! P_Player üzerinde olduðundan emin ol.");
                    return;
                }

                // 3. Mantýksal Kontrol: Anahtar var mý?
                if (inventory.HasItem(m_RequiredKey.ItemID))
                {
                    m_IsLocked = false;
                    Debug.Log("<color=green>[Door]</color> Kilit açýldý!");
                }
                else
                {
                    Debug.Log("<color=red>[Door]</color> Kapý kilitli, anahtar lazým!");
                    return;
                }
            }

            base.OnInteract();
        }
        #endregion
    }
}