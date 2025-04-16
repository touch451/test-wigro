using UnityEditor;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    public void OnExitButtonClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void OnSettingsButtonClick()
    {
        ScreenSwitcher.Instance.GoToSettingsScreen();
    }

    public void OnShopButtonClick()
    {
        ScreenSwitcher.Instance.GoToShopScreen();
    }
}
