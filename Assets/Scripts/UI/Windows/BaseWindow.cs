using Model;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

namespace UI.Windows
{
    public abstract class BaseWindow : MonoBehaviour, IPointerDownHandler
    {
        public static DataModel DataModel;
        public static WindowManager WindowManager;

        [SerializeField]
        private Button _closeBtn;

        //public event Action WindowOpened;
        public event Action WindowClosed;
        protected bool _isDraggable = true;


        protected void Awake()
        {
            _closeBtn.onClick.AddListener(Close);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            transform.SetAsLastSibling();
        }

        public void Close()
        {
            //выберите один из двух вариантов
            //gameObject.SetActive(false);
            Destroy(this.gameObject);

            WindowClosed?.Invoke();
        }
    }
}