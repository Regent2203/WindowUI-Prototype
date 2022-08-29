using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

namespace Model.Shop
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField]
        private Text _itemName;
        [SerializeField]
        private Text _itemPrice;
        [SerializeField]
        private Button _btnBuy;

        public void InitView(ShopItem item, UnityAction buyAction)
        {
            _itemName.text = item.Name;
            _itemPrice.text = item.Price.ToString();

            _btnBuy.onClick.AddListener(buyAction);
        }
    }
}