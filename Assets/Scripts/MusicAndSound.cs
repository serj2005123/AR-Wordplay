using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicAndSound : MonoBehaviour
{
    [SerializeField] public Toggle SoundToggle;
    [SerializeField] public Toggle MusicToggle;
    [SerializeField] public AudioSource ButtonSound;

    
    void Start()
    {
        if(PlayerPrefs.GetInt("SoundToggle") == 1 )
        {
            SoundToggle.isOn = true;
        }
        else
        {
            SoundToggle.isOn = false;
        }
        if (PlayerPrefs.GetInt("MusicToggle") == 1)
        {
            MusicToggle.isOn = true;
        }
        else
        {
            MusicToggle.isOn = false;
        }


    }
    public void ButtonClickSound()
    {
        if (SoundToggle.isOn)
        {
            ButtonSound.Play();
        }
    }

    void Update()
    {
        PlayerPrefs.SetInt("SoundToggle", SoundToggle.isOn ? 1 : 0);
        PlayerPrefs.SetInt("MusicToggle", MusicToggle.isOn ? 1 : 0);
    }
}
