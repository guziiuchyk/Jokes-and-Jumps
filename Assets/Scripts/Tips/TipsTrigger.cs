using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipsTrigger : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] TMP_Text textField;
    [SerializeField] string text;
    private Transform tr;
    private Transform canvasTransform;

    private void Start()
    {
        canvasTransform = canvas.GetComponent<Transform>();
        tr = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            canvasTransform.position = new Vector2 (transform.position.x + 0.5f, transform.position.y + 2.5f);
            textField.SetText (text);
            canvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "Player" && canvas != null)
        {
            canvas.SetActive(false);
        }
    }

}
