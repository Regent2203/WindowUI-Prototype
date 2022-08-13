using UI.Configs;
using UnityEngine;
using UI.Windows;

namespace Model
{
    public class DataModel 
    {
        private WindowManager _windowManager;

        public DataModel(WindowConfig windowConfig, Canvas canvas)
        {
            _windowManager = new WindowManager(windowConfig, canvas.transform);

            _windowManager.ShowWindow(WndId.Main);
        }
    }
}