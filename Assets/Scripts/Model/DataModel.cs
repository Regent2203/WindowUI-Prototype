using Configs;
using UnityEngine;
using UI.Windows;

namespace Model
{
    public class DataModel 
    {
        public SettingsModel SettingsModel { get; protected set; }
        public MessagesModel MessagesModel { get; protected set; }
        public ShopModel ShopModel { get; protected set; }


        public DataModel()
        {
            SettingsModel = new SettingsModel();
            MessagesModel = new MessagesModel();
            ShopModel = new ShopModel();
        }
    }
}