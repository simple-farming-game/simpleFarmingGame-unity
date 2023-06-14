using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider SoundBar;

    public void SetBgm()
    {
        audioMixer.SetFloat("BGM", SoundBar.value * 20);
        Debug.Log(SoundBar.value * 20);
    }
}