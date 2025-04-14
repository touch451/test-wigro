using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioConfig", menuName = "Configs/AudioConfig")]
public class AudioConfig : ScriptableObject
{
    public AudioClip click;
    public float clickVolume = 0.5f;
}