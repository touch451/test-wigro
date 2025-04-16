using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProductItem : MonoBehaviour
{
    [SerializeField] private ProductType productType;
    [SerializeField] private Image productIcon;

    private UnityEvent<ProductItem> onItemClick = new UnityEvent<ProductItem>();

    public Image Icon => productIcon;
    public ProductType Type => productType;

    public void OnItemClick()
    {
        onItemClick?.Invoke(this);
    }

    public void SetListenerOnClick(UnityAction<ProductItem> action)
    {
        onItemClick.AddListener(action);
    }
}
