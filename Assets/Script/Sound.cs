using UnityEngine.UI;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource SoundAS;
    public Slider SoundBar;

    void Start()
    {
        SoundAS = GetComponent<AudioSource>();
    }

    public void SetBgm()
    {
        SoundAS.volume = SoundBar.value;
    }
}