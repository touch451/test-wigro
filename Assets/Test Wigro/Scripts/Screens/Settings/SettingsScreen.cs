using UnityEngine;

public class SettingsScreen : ScreenBase
{
    [SerializeField] private SettingsToggle soundToggle;
    [SerializeField] private SettingsToggle musicToggle;

    private string TAG = "[Settings] ";

    private void Start()
    {
        InitToggles();
    }

    private void InitToggles()
    {
        bool isOnSound = PlayerPrefs.GetInt(Constants.SOUND_KEY, 1) == 1;
        soundToggle.SetToggle(isOnSound);

        bool isOnMusic = PlayerPrefs.GetInt(Constants.MUSIC_KEY, 1) == 1;
        musicToggle.SetToggle(isOnMusic);
    }

    public void OnSoundToggleClick()
    {
        bool isSoundOn = PlayerPrefs.GetInt(Constants.SOUND_KEY, 1) == 1;

        isSoundOn = !isSoundOn;
        soundToggle.SwitchToggle(isSoundOn);

        PlayerPrefs.SetInt(Constants.SOUND_KEY, isSoundOn ? 1 : 0);
        Debug.Log(TAG + (isSoundOn ? "Sound is ON" : "Sound is OFF"));
    }

    public void OnMusicToggleClick()
    {
        bool isMusicOn = PlayerPrefs.GetInt(Constants.MUSIC_KEY, 1) == 1;

        isMusicOn = !isMusicOn;
        musicToggle.SwitchToggle(isMusicOn);

        PlayerPrefs.SetInt(Constants.MUSIC_KEY, isMusicOn ? 1 : 0);
        Debug.Log(TAG + (isMusicOn ? "Music is ON" : "Music is OFF"));
    }

    public void OnExitButtonClick()
    {
        ScreenSwitcher.Instance.ReturnToMenuScreen();
    }
}
