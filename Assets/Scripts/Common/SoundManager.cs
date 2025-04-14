using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioConfig config;
    [SerializeField] private AudioSource audioSource;

    public void PlayClick()
    {
        audioSource.PlayOneShot(config.click, config.clickVolume);
    }
}
