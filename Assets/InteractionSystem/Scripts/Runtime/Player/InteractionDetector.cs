using System;
using InteractionSystem.Runtime.Core;
using UnityEngine;

namespace InteractionSystem.Runtime.Player
{
    /// <summary>
    /// Oyuncunun bakýþ açýsýndaki etkileþime geçilebilir nesneleri algýlayan sýnýf.
    /// </summary>
    public class InteractionDetector : MonoBehaviour
    {
        #region Fields

        [Header("Settings")]
        [SerializeField] private float m_InteractionRange = 3f;
        [SerializeField] private float m_CheckInterval = 0.1f;
        [SerializeField] private LayerMask m_InteractableLayer;
        [SerializeField] private KeyCode m_InteractionKey = KeyCode.E;

        [Header("References")]
        [SerializeField] private Transform m_RaycastOrigin;

        private IInteractable m_CurrentInteractable;
        private float m_LastCheckTime;

        #endregion

        #region Events

        public event Action<IInteractable> OnInteractableFound;
        public event Action OnInteractableLost;

        #endregion

        #region Unity Methods

        private void Update()
        {
            // Belirli aralýklarla algýlama yap
            if (Time.time - m_LastCheckTime > m_CheckInterval)
            {
                PerformDetection();
                m_LastCheckTime = Time.time;
            }

            HandleInteractionInput();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Raycast kullanarak oyuncunun önündeki nesneyi tespit eder.
        /// </summary>
        private void PerformDetection()
        {
            Ray ray = new Ray(m_RaycastOrigin.position, m_RaycastOrigin.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, m_InteractionRange, m_InteractableLayer))
            {
                if (hit.collider.TryGetComponent(out IInteractable interactable))
                {
                    if (interactable.CanInteract)
                    {
                        if (m_CurrentInteractable != interactable)
                        {
                            m_CurrentInteractable = interactable;
                            OnInteractableFound?.Invoke(m_CurrentInteractable);
                        }
                        return;
                    }
                }
            }
            ClearCurrentInteractable();
        }

        private void HandleInteractionInput()
        {
            if (m_CurrentInteractable == null) return;

            if (Input.GetKeyDown(m_InteractionKey))
                m_CurrentInteractable.OnInteract();
        }

        private void ClearCurrentInteractable()
        {
            if (m_CurrentInteractable != null)
            {
                m_CurrentInteractable = null;
                OnInteractableLost?.Invoke();
            }
        }

        #endregion

        #region Debug

        private void OnDrawGizmosSelected()
        {
            if (m_RaycastOrigin == null) return;

            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(m_RaycastOrigin.position, m_RaycastOrigin.position + m_RaycastOrigin.forward * m_InteractionRange);
        }

        #endregion
    }
}