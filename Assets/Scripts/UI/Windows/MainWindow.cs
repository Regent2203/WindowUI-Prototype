using UnityEngine;
using UnityEngine.UI;
using UI.Windows;

namespace UI.Windows
{
    public class MainWindow : BaseWindow
    {
        [SerializeField]
        private Button _shopBtn;

        [SerializeField]
        private Button _settingsBtn;

        [SerializeField]
        private Button _messagesBtn;


        void Start()
        {
            _shopBtn.onClick.AddListener(() => WindowManager.ShowWindow(WndId.Shop));
            _settingsBtn.onClick.AddListener(() => WindowManager.ShowWindow(WndId.Settings));

            _messagesBtn.onClick.AddListener(() => WindowManager.ShowWindow(WndId.Messages));
        }
    }
}