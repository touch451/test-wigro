using UnityEngine;
using UnityEngine.UI;

public class PurchasePopup : PopupBase
{
    [SerializeField] private Image icon;

    private ProductItem item;

    public void Show(ProductItem productItem)
    {
        item = productItem;
        SetProductIcon(item.Icon.sprite);

        base.Show();
    }

    private void SetProductIcon(Sprite sprite)
    {
        icon.sprite = sprite;
        icon.SetNativeSize();
    }

    public void OnBuyButtonClick()
    {
        Debug.Log("Buy product - " + item.Type);
        base.Hide();
    }

    public void OnCancelButtonCLick()
    {
        base.Hide();
    }
}
