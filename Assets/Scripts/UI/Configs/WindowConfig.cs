using UnityEngine;
using UI.Windows;

namespace Configs
{
    public class WindowConfig : ScriptableObject
    {
        [System.Serializable]
        public class WindowDictionary : SerializableDictionary<WndId, BaseWindow> { }
        
        [SerializeField]
        private WindowDictionary _config = new WindowDictionary();


        public BaseWindow TryGetWindow(WndId wndId)
        {
            if (_config.TryGetValue(wndId, out var window))
            {
                if (window == null)
                    Debug.LogError($"Prefab isn't set for key {wndId} in {nameof(WindowConfig)}");

                return window;
            }
            else
            {
                Debug.LogError($"Key {wndId} isn't set in {nameof(WindowConfig)}");
                return null;
            }
        }
    }
}