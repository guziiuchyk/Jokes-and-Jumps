using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : Sounds
{
    public GameObject dieCanvas;
    [SerializeField] GameObject FirstButton;
    [SerializeField] ChangeSelectedEventSystem changeSelectedEventSystem;
    [SerializeField] Animator animator;
    private void OnEnable()
    {
        SpikeTrigger.onDied += Die;
        OpenChest.OnDied += Die;
    }
    private void OnDisable()
    {
        SpikeTrigger.onDied -= Die;
        OpenChest.OnDied -= Die;
    }
    public void Play()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void Die()
    {
        animator.SetBool("IsDead", true);
        Debug.Log("DEAD");

        if (Settings.IsAutoRespawn)
        {
            Play();
        }
        else
        {
            if (Settings.IsDarkSoulsOn) 
            {
                PlaySound(sounds[1], volume: 2.5f, p1: 1f, p2: 1.1f);
            }
            else
            {
                PlaySound(sounds[0], volume: 1f, p1: 1f, p2: 1.1f);
            }
            Time.timeScale = 0f;
            dieCanvas.SetActive(true);
            changeSelectedEventSystem.changeSelected(FirstButton);
        }
    }
}
