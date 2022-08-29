using UnityEngine;
using UnityEngine.UI;
using UI.Windows;
using Model;
using Model.Shop;

public class ShopWindow : BaseWindow
{
    [SerializeField]
    private ShopItemView _shopItemViewPrefab;

    [SerializeField]
    private RectTransform _itemsRoot;

    private ShopModel _shopModel => DataModel.ShopModel;


    private void Start()
    {
        CreateViews();
    }

    private void CreateViews()
    {
        foreach (var item in _shopModel.Items.Values)
        {
            var obj = GameObject.Instantiate(_shopItemViewPrefab, _itemsRoot);
            obj.InitView(item, () => _shopModel.TryBuyItem(item.Id));
        }
    }
}
