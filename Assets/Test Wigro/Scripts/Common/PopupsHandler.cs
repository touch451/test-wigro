using UnityEngine;

public class PopupsHandler : MonoBehaviour
{
    [Header("Popups:")]
    public PurchasePopup purchasePopup;

    public static PopupsHandler Instance;

    private void Awake()
    {
        SetInstance();
    }

    private void SetInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
    }
}
