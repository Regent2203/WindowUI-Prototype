using UnityEngine;
using UnityEngine.UI;
using UI.Windows;
using Model;
using Model.Messages;
using System.Collections.Generic;

public class MessagesWindow : BaseWindow
{
    [SerializeField]
    private MessageView  _messageViewPrefab;

    [SerializeField]
    private RectTransform _itemsRoot;

    [SerializeField]
    private ScrollRect _scroll;

    private MessagesModel _messagesModel => DataModel.MessagesModel;


    private void Start()
    {
        CreateViews();

        _messagesModel.ModelUpdated += CreateViews;
    }

    private void CreateViews()
    {
        foreach (Transform child in _itemsRoot)        
            GameObject.Destroy(child.gameObject);        

        foreach (var item in _messagesModel.Messages.Values)
        {
            var obj = GameObject.Instantiate(_messageViewPrefab, _itemsRoot); //если часто пересоздаем, то можно реализовать пул объектов
            obj.InitView(item, () => _messagesModel.TryDeleteMessage(item.Id));
        }

        _scroll.verticalScrollbar.value = 1;
    }
}
