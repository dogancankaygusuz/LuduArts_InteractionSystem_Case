using InteractionSystem.Runtime.Core;
using UnityEngine;
using UnityEngine.Events;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Belirli bir süre basýlý tutma gerektiren etkileþimler için temel sýnýf.
    /// </summary>
    public class HoldInteractable : InteractableBase
    {
        #region Fields

        [Header("Hold Settings")]
        [SerializeField] private float m_HoldDuration = 2f;

        public UnityEvent OnHoldComplete;

        #endregion

        #region Properties

        public float HoldDuration => m_HoldDuration;

        #endregion

        #region Methods

        public override void OnInteract()
        {
        }

        /// <summary>
        /// Basýlý tutma iþlemi baþarýyla tamamlandýðýnda çaðrýlýr.
        /// </summary>
        public virtual void InteractComplete()
        {
            Debug.Log($"<color=cyan>[Hold Interaction]</color> {gameObject.name} tamamlandý!");
            OnHoldComplete?.Invoke();
        }

        #endregion
    }
}