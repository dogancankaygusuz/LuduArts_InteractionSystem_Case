using InteractionSystem.Runtime.Core;
using UnityEngine;
using UnityEngine.Events;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Açýk/Kapalý gibi iki durumlu etkileþimler için temel sýnýf.
    /// </summary>
    public class ToggleInteractable : InteractableBase
    {
        #region Fields

        [Header("Toggle Settings")]
        [SerializeField] protected bool m_IsToggled = false;

        public UnityEvent<bool> OnToggleChanged;

        #endregion

        #region Properties

        public bool IsToggled => m_IsToggled;

        #endregion

        #region Methods

        public override void OnInteract()
        {
            m_IsToggled = !m_IsToggled;
            OnToggleChanged?.Invoke(m_IsToggled);

            Debug.Log($"<color=orange>[Toggle Interaction]</color> {gameObject.name} durumu: {(m_IsToggled ? "Açýk" : "Kapalý")}");
        }

        #endregion
    }
}