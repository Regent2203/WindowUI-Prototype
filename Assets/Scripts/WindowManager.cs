using UnityEngine;
using UI.Windows;
using Configs;
using System.Collections.Generic;

namespace Model
{
    public class WindowManager
    {
        private int _windowsMaxCount = 10; //по заданию
        private int _windowsCount => _windowsList.Count;
        private LinkedList<BaseWindow> _windowsList = new LinkedList<BaseWindow>();

        private WindowConfig _windowConfig;
        private Transform _root => UICanvas.Root;


        public WindowManager(WindowConfig windowConfig)
        {
            _windowConfig = windowConfig;
        }

        public void ShowWindow(WndId wndId)
        {
            var window = _windowConfig.TryGetWindow(wndId);
            if (window == null)
                return;
            
            if (ManageMaxCount())
                CreateWindow(window);
        }

        private bool ManageMaxCount()
        {
            if (_windowsCount == _windowsMaxCount)
            {
                Debug.LogWarning("Too many windows are opened currently! Please close at least one.");
                return false;
            }
            return true;
        }

        private void CreateWindow(BaseWindow window)
        {
            window = GameObject.Instantiate(window, _root);
            var node = _windowsList.AddLast(window);
            window.WindowClosed += () => _windowsList.Remove(node);            
        }
    }
}