using InteractionSystem.Runtime.Core;
using UnityEngine;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Detector'ý test etmek için kullanýlan basit etkileþim sýnýfý.
    /// </summary>
    public class TestInteractable : InteractableBase
    {
        #region Methods

        public override void OnInteract()
        {
            Debug.Log($"<color=green>[Interaction]</color> {gameObject.name} ile etkileþime geçildi!");

            // Görsel geri bildirim için rengini deðiþtirelim
            if (TryGetComponent(out Renderer renderer))
                renderer.material.color = Random.ColorHSV();
        }

        #endregion
    }
}