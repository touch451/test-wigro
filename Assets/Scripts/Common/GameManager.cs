using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Main:")]
    [SerializeField] private SoundManager sound;

    [Header("Screens:")]
    [SerializeField] private MenuScreen menuScreen;
    [SerializeField] private ShopScreen shopScreen;
    [SerializeField] private SettingsScreen settingsScreen;

    public static GameManager Instance;
    public SoundManager Sound => sound;

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
            Destroy(gameObject);
        }
    }
}
