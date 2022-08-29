using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Events;

namespace Model.Messages
{
    public class MessageView : MonoBehaviour
    {
        [SerializeField]
        private Text _title;
        [SerializeField]
        private Text _body;
        [SerializeField]
        private Text _date;
        [SerializeField]
        private Button _btnDelete;

        public void InitView(Message item, UnityAction deleteAction)
        {
            _title.text = item.Title;
            _body.text = item.Body;
            _date.text = $"Дата: {item.DateSent} ";

            _btnDelete.onClick.AddListener(deleteAction);
        }
    }
}