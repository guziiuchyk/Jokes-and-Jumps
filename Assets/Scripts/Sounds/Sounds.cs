using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] public AudioClip[] sounds;

    private AudioSource audioSrc => GetComponent<AudioSource>();

    public void PlaySound(AudioClip clip, float volume = 1f, bool destroyed = false, float p1 = 0.90f, float p2 = 1.10f)
    {
        if (Settings.IsSoundsOn)
        {
            audioSrc.pitch = Random.Range(p1, p2);
            audioSrc.PlayOneShot(clip, volume);
        }
    }
}
