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

        [Header("Visual Feedback")]
        [SerializeField] private Color m_HighlightColor = Color.yellow;
        private Color m_OriginalColor;
        private Renderer m_Renderer;
        #endregion

        #region Properties

        public InteractionType InteractionType => m_InteractionType;
        public string InteractionPrompt => m_InteractionPrompt;
        public bool CanInteract => m_CanInteract;

        #endregion

        #region Methods
        protected virtual void Awake()
        {
            m_Renderer = GetComponentInChildren<Renderer>();
            if (m_Renderer != null) m_OriginalColor = m_Renderer.material.color;
        }

        public virtual void OnHoverEnter()
        {
            if (m_Renderer != null) m_Renderer.material.color = m_HighlightColor;
        }

        public virtual void OnHoverExit()
        {
            if (m_Renderer != null) m_Renderer.material.color = m_OriginalColor;
        }
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