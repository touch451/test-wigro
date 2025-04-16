using UnityEngine;

public class ScreenSwitcher : MonoBehaviour
{
    [SerializeField] private float switchTime = 1f;

    [Header("Screens:")]
    [SerializeField] private MenuScreen menuScreen;
    [SerializeField] private ShopScreen shopScreen;
    [SerializeField] private SettingsScreen settingsScreen;

    public static ScreenSwitcher Instance;

    private void Awake()
    {
        SetInstance();
    }

    private void Start()
    {
        menuScreen.ShowScreen(duration: 1f);
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

    public void GoToSettingsScreen()
    {
        menuScreen.HideScreen(switchTime);
        settingsScreen.ShowScreen(switchTime);
    }

    public void GoToShopScreen()
    {
        menuScreen.HideScreen(switchTime);
        shopScreen.ShowScreen(switchTime);
    }

    public void ReturnToMenuScreen()
    {
        shopScreen.HideScreen(switchTime);
        settingsScreen.HideScreen(switchTime);

        menuScreen.ShowScreen(switchTime);
    }
}
