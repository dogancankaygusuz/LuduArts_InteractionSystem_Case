using UnityEngine;

namespace InteractionSystem.Runtime.Interactables
{
    /// <summary>
    /// Baþka bir nesneyi tetiklemek için kullanýlan þalter/kol sýnýfý.
    /// </summary>
    public class Switch : ToggleInteractable
    {
        #region Fields

        [Header("Switch Visuals")]
        [SerializeField] private Transform m_HandleTransform;
        [SerializeField] private Vector3 m_OnRotation = new Vector3(0, 0, 45);
        [SerializeField] private Vector3 m_OffRotation = new Vector3(0, 0, -45);

        #endregion

        #region Methods

        public override void OnInteract()
        {
            base.OnInteract();

            if (m_HandleTransform != null)
                m_HandleTransform.localRotation = Quaternion.Euler(m_IsToggled ? m_OnRotation : m_OffRotation);
        }

        #endregion
    }
}