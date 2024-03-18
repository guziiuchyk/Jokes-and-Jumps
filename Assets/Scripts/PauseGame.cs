using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool pauseGame;
    [SerializeField] GameObject PauseGameMenu;
    [SerializeField] GameObject TipsCanvas;
    [SerializeField] GameObject FirstButton;
    [SerializeField] ChangeSelectedEventSystem changeSelectedEventSystem;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseGameMenu.SetActive(false);
        TipsCanvas.SetActive(true);
        Time.timeScale = 1.0f;
        pauseGame = false;
    }
    public void Pause()
    {
        changeSelectedEventSystem.changeSelected(FirstButton);
        PauseGameMenu.SetActive(true);
        TipsCanvas.SetActive(false);
        Time.timeScale = 0f;
        pauseGame = true;
    }
}
