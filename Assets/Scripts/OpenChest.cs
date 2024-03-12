using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : Sounds
{
    public int index = 0;
    [SerializeField] GameObject ConfirmCanvas;
    public static Action OnDied;
    [SerializeField] GameObject key;
    [SerializeField] ChangeGravity changeGravity;
    public void OpenChestByIndex()
    {
        Time.timeScale = 1;
        if(index == 1) 
        {
            ConfirmCanvas.SetActive(false);
            OnDied?.Invoke();
        }
        else
        {
            PlaySound(sounds[0]);
            Destroy(key);
            ConfirmCanvas.SetActive(false);
            changeGravity.makeNegativeGravity();
            Debug.Log("Lucker");
        }
    }

    public void NoCancel()
    {
        ConfirmCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
