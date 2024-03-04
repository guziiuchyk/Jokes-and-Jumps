using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    [SerializeField] string createdTag;
    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(createdTag);
        if (obj != this.gameObject)
        {

            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }
}
