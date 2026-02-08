using InteractionSystem.Runtime.Core;
using InteractionSystem.Runtime.Player;
using TMPro;
using UnityEngine;

namespace InteractionSystem.Runtime.UI
{
    /// <summary>
    /// Ekranda etkileþim ipuçlarýný gösteren UI sýnýfý.
    /// </summary>
    public class InteractionPromptUI : MonoBehaviour
    {
        #region Fields

        [Header("References")]
        [SerializeField] private InteractionDetector m_Detector;
        [SerializeField] private TextMeshProUGUI m_PromptText;
        [SerializeField] private GameObject m_PromptPanel;

        #endregion

        #region Unity Methods

        private void OnEnable()
        {
            if (m_Detector != null)
            {
                m_Detector.OnInteractableFound += ShowPrompt;
                m_Detector.OnInteractableLost += HidePrompt;
            }
            HidePrompt();
        }

        private void OnDisable()
        {
            if (m_Detector != null)
            {
                m_Detector.OnInteractableFound -= ShowPrompt;
                m_Detector.OnInteractableLost -= HidePrompt;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Bulunan nesnenin bilgilerine göre UI'ý günceller ve gösterir.
        /// </summary>
        private void ShowPrompt(IInteractable interactable)
        {
            m_PromptText.text = $"[E] {interactable.InteractionPrompt}";
            m_PromptPanel.SetActive(true);
        }

        /// <summary>
        /// UI'ý gizler.
        /// </summary>
        private void HidePrompt()
        {
            m_PromptPanel.SetActive(false);
        }

        #endregion
    }
}