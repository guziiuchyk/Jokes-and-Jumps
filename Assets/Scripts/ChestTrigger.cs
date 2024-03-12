using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class ChestTrigger : MonoBehaviour
{
    [SerializeField] int index = 1;
    [SerializeField] OpenChest openChest;
    [SerializeField] GameObject ConfirmCanvas;
    [SerializeField] Key key;
    [SerializeField] ChangeSelectedEventSystem changeSelectedEventSystem;
    [SerializeField] GameObject FirstButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player" && key.IsFollow)
        {
            openChest.index = index;
            Time.timeScale = 0;
            ConfirmCanvas.SetActive(true);
            changeSelectedEventSystem.changeSelected(FirstButton);
        }
    }
}
