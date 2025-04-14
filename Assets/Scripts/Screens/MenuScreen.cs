using UnityEditor;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    public void OnExitClick()
    {
        GameManager.Instance.Sound.PlayClick();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void OnSettingsClick()
    {
        GameManager.Instance.Sound.PlayClick();
    }

    public void OnShopClick()
    {
        GameManager.Instance.Sound.PlayClick();
    }
}
