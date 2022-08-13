using UnityEngine;
using UI.Windows;
using UI.Configs;

namespace Model
{
    public class WindowManager
    {
        private WindowConfig _windowConfig;
        private Transform _canvasTransform;

        public WindowManager(WindowConfig windowConfig, Transform canvasTransform)
        {
            _windowConfig = windowConfig;
            _canvasTransform = canvasTransform;
        }

        public bool ShowWindow(WndId wndId)
        {
            var window = _windowConfig.TryGetWindow(wndId);
            if (window == null)
                return false;

            GameObject.Instantiate(window.gameObject, _canvasTransform);
            return true;
        }
    }
}