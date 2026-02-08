using UnityEngine;

namespace InteractionSystem.Runtime.Core
{
    /// <summary>
    /// Tüm etkileþime geçilebilir nesneler için temel sýnýf.
    /// </summary>
    public abstract class InteractableBase : MonoBehaviour, IInteractable
    {
        #region Fields

        [Header("Base Interaction Settings")]
        [SerializeField] private InteractionType m_InteractionType = InteractionType.Instant;
        [SerializeField] private string m_InteractionPrompt = "Interact";
        [SerializeField] private bool m_CanInteract = true;

        #endregion

        #region Properties

        public InteractionType InteractionType => m_InteractionType;
        public string InteractionPrompt => m_InteractionPrompt;
        public bool CanInteract => m_CanInteract;

        #endregion

        #region Methods

        /// <summary>
        /// Etkileþim gerçekleþtiðinde çaðrýlýr. Alt sýnýflar bunu override etmelidir.
        /// </summary>
        public abstract void OnInteract();

        /// <summary>
        /// Etkileþim durumunu deðiþtirmek için kullanýlýr.
        /// </summary>
        public void SetInteractableState(bool newState)
        {
            m_CanInteract = newState;
        }

        #endregion
    }
}