using System.Collections.Generic;
using UnityEngine;

public class ShopScreen : ScreenBase
{
    [SerializeField] private List<ProductItem> productsItems = new List<ProductItem>();

    private void Start()
    {
        SetListeners();
    }

    private void SetListeners()
    {
        for (int i = 0; i < productsItems.Count; i++)
        {
            var item = productsItems[i];
            item.SetListenerOnClick(OnProductItemClick);
        }
    }

    public void OnExitButtonClick()
    {
        ScreenSwitcher.Instance.ReturnToMenuScreen();
    }

    private void OnProductItemClick(ProductItem clickedItem)
    {
        PopupsHandler.Instance.purchasePopup.Show(clickedItem);
    }
}
