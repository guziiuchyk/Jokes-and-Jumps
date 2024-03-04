using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSettings : Sounds
{
    [SerializeField] AudioClip ArcadeMusic;
    [SerializeField] AudioClip DKMusic;
    AudioSource Music;
    [SerializeField] Toggle IsMusicOnButton;
    [SerializeField] Toggle IsSoundsOnButton;
    [SerializeField] Toggle IsAutoRespawnOnButton;
    [SerializeField] Toggle IsDarkSouldOnButton;
    private void Start()
    {
        Music = GameObject.FindWithTag("MUSIC_CREATED").GetComponent<AudioSource>();
        IsMusicOnButton.isOn = Settings.IsMusicOn;
        IsSoundsOnButton.isOn = Settings.IsSoundsOn;
        IsAutoRespawnOnButton.isOn = Settings.IsAutoRespawn;
        IsDarkSouldOnButton.isOn = Settings.IsDarkSoulsOn;
    }
    public void ChangeIsSoundsOn(bool state)
    {
        Settings.IsSoundsOn = state;
    }
    public void ChangeIsMusicOn(bool state)
    {
        if (state)
        {
            Music.Play();
        }
        else
        {
            Music.Stop();
        }
        Settings.IsMusicOn = state;
    }
    public void ChangeIsAutoRespawnOn(bool state)
    {
        Settings.IsAutoRespawn = state;
    }
    public void ChangeIsDarkSoulsOn(bool state)
    {
        if (state)
        {
            PlaySound(sounds[0]);
            Music.Stop();
            Music.resource = DKMusic;
            Music.Play();
        }
        else
        {
            Music.Stop();
            Music.resource = ArcadeMusic;
            Music.Play();
        }
        Settings.IsDarkSoulsOn = state;
    }
}
