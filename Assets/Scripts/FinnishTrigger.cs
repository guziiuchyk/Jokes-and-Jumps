using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnishTrigger : Sounds
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject FirstButton;
    [SerializeField] ChangeSelectedEventSystem changeSelectedEventSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            if (Settings.IsDarkSoulsOn)
            {
                PlaySound(sounds[1]);
            }
            else
            {
                PlaySound(sounds[0]);
            }
            Time.timeScale = 0f;
            canvas.SetActive(true);
            changeSelectedEventSystem.changeSelected(FirstButton);
        }
    }
}
