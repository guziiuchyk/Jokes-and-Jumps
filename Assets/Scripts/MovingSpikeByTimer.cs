using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSpikeByTimer : MonoBehaviour
{
    private float time = 0f;
    [SerializeField] bool IsOpen = false;
    [SerializeField] int x = 0;
    [SerializeField] int y = 0;
    private Transform tr;
    public float speed = 1.0F;
    private float startTime;
    private Vector3 startPos;
    private Vector3 endPos;
    private void Start()
    {
        tr = GetComponent<Transform>();
        startPos = transform.position;
        endPos = new Vector3(x, y, 0);
        startTime = Time.time;
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time > 1f)
        {
            time = 0f;
            IsOpen = !IsOpen;
            startTime = Time.time;
        }
        if (IsOpen)
        {
            float journeyLength = Vector3.Distance(startPos, endPos);
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startPos, endPos, fracJourney);
        }
        else
        {
            float journeyLength = Vector3.Distance(endPos, startPos);
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(endPos, startPos, fracJourney);
        }
    }
}
