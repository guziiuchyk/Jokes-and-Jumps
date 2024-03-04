using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeSelectedEventSystem : MonoBehaviour
{
    [SerializeField] EventSystem _eventSystem;

    public void changeSelected(GameObject btn)
    {
        _eventSystem.SetSelectedGameObject(btn);
    }
}
