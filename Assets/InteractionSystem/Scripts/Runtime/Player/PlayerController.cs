using UnityEngine;

namespace InteractionSystem.Runtime.Player
{
    /// <summary>
    /// Oyuncunun hareket ve bakýþ kontrollerini yöneten sýnýf.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour
    {
        #region Fields

        [Header("Movement Settings")]
        [SerializeField] private float m_MoveSpeed = 5f;
        [SerializeField] private float m_LookSensitivity = 2f;
        [SerializeField] private float m_Gravity = -9.81f;

        [Header("References")]
        [SerializeField] private Transform m_CameraTransform;

        private CharacterController m_CharacterController;
        private Vector3 m_Velocity;
        private float m_XRotation = 0f;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            m_CharacterController = GetComponent<CharacterController>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            HandleRotation();
            HandleMovement();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Mouse hareketlerine göre kamerayý ve gövdeyi döndürür.
        /// </summary>
        private void HandleRotation()
        {
            float mouseX = Input.GetAxis("Mouse X") * m_LookSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * m_LookSensitivity;

            m_XRotation -= mouseY;
            m_XRotation = Mathf.Clamp(m_XRotation, -90f, 90f);
            m_CameraTransform.localRotation = Quaternion.Euler(m_XRotation, 0f, 0f);

            transform.Rotate(Vector3.up * mouseX);
        }

        private void HandleMovement()
        {
            if (m_CharacterController.isGrounded && m_Velocity.y < 0)
                m_Velocity.y = -2f;

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;
            m_CharacterController.Move(move * m_MoveSpeed * Time.deltaTime);

            m_Velocity.y += m_Gravity * Time.deltaTime;
            m_CharacterController.Move(m_Velocity * Time.deltaTime);
        }

        #endregion
    }
}