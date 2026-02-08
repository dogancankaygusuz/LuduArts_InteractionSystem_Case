using UnityEngine;

namespace InteractionSystem.Runtime.Core
{
    /// <summary>
    /// Envantere girebilen eþyalar için temel veri sýnýfý.
    /// </summary>
    [CreateAssetMenu(fileName = "SO_Item_New", menuName = "LuduArts/Item Data")]
    public class ItemData : ScriptableObject
    {
        #region Fields

        [SerializeField] private string m_ItemID;
        [SerializeField] private string m_ItemName;
        [SerializeField] private Sprite m_Icon;

        #endregion

        #region Properties

        public string ItemID => m_ItemID;
        public string ItemName => m_ItemName;
        public Sprite Icon => m_Icon;

        #endregion
    }
}