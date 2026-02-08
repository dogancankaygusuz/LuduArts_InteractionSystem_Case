using UnityEngine;

namespace InteractionSystem.Runtime.Core
{
    /// <summary>
    /// Tüm etkileþime geçilebilir nesnelerin uygulamasý gereken arayüz.
    /// </summary>
    public interface IInteractable
    {
        #region Properties

        InteractionType InteractionType { get; }
        string InteractionPrompt { get; }
        bool CanInteract { get; }

        #endregion

        #region Methods

        void OnInteract();
        void OnHoverEnter();
        void OnHoverExit();
        #endregion
    }
}