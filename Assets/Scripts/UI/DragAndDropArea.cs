using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace UI
{
    public class DragAndDropArea : Image, IDragHandler
    {
        [SerializeField]
        private RectTransform _parent;

        public void OnDrag(PointerEventData eventData)
        {
            _parent.transform.position += (Vector3)eventData.delta;
            _parent.transform.SetAsLastSibling();
        }
    }
}