using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform tr;
    private bool IsItWorked = false;
    public void makeNegativeGravity()
    {
        if(!IsItWorked)
        {
            rb.gravityScale = -4;
            tr.rotation = Quaternion.Euler(180, 0, 0);
        }
    }
}
