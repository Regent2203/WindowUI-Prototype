using System;
using System.Collections.Generic;
using Model.Shop;

namespace Model
{
    public class ShopModel : IModel
    {
        private Dictionary<int, ShopItem> _shopItems = new Dictionary<int, ShopItem>();
        public event Action ModelUpdated;
        public Dictionary<int, ShopItem> Items => _shopItems;


        public ShopModel()
        {
            Init();
        }

        public void Init()
        {
            LoadFromServer();
#if DEBUG
            LoadFake();
#endif
        }

        private void LoadFromServer() //not implemented for prototype
        {
            //_shopItems.Clear();

            //загружаем откуда-нибудь с сервера все имеющиеся товары магазина
            //var shopItem = JSON.Deserialize(...);
            //AddItem(item);
        }

        private void LoadFake()
        {
            _shopItems.Clear();

            //заглушка-пример для прототипа:
            var exampleList = new List<ShopItem>()
            {
                new ShopItem(1001, "Эликсир защиты", 50, ShopItemType.Usable, 5),
                new ShopItem(1002, "Шапка-Невидимка", 5000, ShopItemType.Equipment),
                new ShopItem(2000, "Премиум на месяц", 100500, ShopItemType.Other),
            };
            
            foreach (var item in exampleList)
                AddItem(item);
        }

        private void AddItem(ShopItem item)
        {
            _shopItems.Add(item.Id, item);
        }

        public void TryBuyItem(int id)
        {
            if (_shopItems.ContainsKey(id))
            {
                //Server.SendRequest("BuyItem", id).OnComplete(); //отправляем на сервер запрос на покупку вещи из магазина
                OnComplete(); //debug

                void OnComplete()
                {
                    //что-то делаем
                    UnityEngine.Debug.Log($"Покупка товара {_shopItems[id].Name}, Id = {id}");
                }
            }
        }
    }
}