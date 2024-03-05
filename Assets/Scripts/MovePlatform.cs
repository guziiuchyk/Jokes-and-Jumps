using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform centerObject; 
    public float rotationSpeed = 80f; 
    public bool isPlayerInside = false;
    private float currentRotation = 0f;
    public bool isPlayerOnBlock = false;

    void Update()
    {
        if(!isPlayerOnBlock)
        {
            if (isPlayerInside)
            {

                if (currentRotation < 180f)
                {
                    transform.RotateAround(centerObject.position, Vector3.forward, rotationSpeed * Time.deltaTime);
                    currentRotation += rotationSpeed * Time.deltaTime;
                }
            }
            else
            {
                if (currentRotation > 0f)
                {
                    transform.RotateAround(centerObject.position, Vector3.back, rotationSpeed * Time.deltaTime);
                    currentRotation -= rotationSpeed * Time.deltaTime;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerOnBlock = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerOnBlock = false;
    }
}