using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows
{
    public abstract class BaseWindow : MonoBehaviour
    {
        [SerializeField]
        private Text _header;

        public void Show()
        {

        }

        public void Close()
        {
            //выберите один из двух вариантов
            //gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}