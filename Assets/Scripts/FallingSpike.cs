using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    [SerializeField] GameObject Key;
    [SerializeField] public bool isMoving = false;
    [SerializeField] Orientation orientation;
    [SerializeField] float speed = 6f;
    [Header("")]
    [SerializeField] bool IsMoveTo = false;
    [SerializeField] int x = 0;
    [SerializeField] int y = 0;
    [Header("")]
    [SerializeField] bool IsRotate = false;
    [SerializeField] int z = 0;
    [SerializeField] float RotatinSpeed = 1.0f;
    [Header("")]
    [SerializeField] bool isKeyRequired = false;
    private Key key;
    public enum Orientation
    {
        Left,
        Right,
        Up,
        Down
    }
    private void Start()
    {
        if (Key)
        {
            key = Key.GetComponent<Key>();
        }
    }
    private void FixedUpdate()
    {
        if (isKeyRequired)
        {
            if (!key.IsFollow)
            {
                isMoving = false;
                return;
            } 
        }
        if (isMoving && !IsMoveTo && !IsRotate)
        {
            switch (orientation)
            {
                case Orientation.Left:
                    transform.Translate(Vector2.left * Time.fixedDeltaTime * speed);
                    break;
                case Orientation.Right:
                    transform.Translate(Vector2.right * Time.fixedDeltaTime * speed);
                    break;
                case Orientation.Up:
                    transform.Translate(Vector2.up * Time.fixedDeltaTime * speed);
                    break;
                case Orientation.Down:
                    transform.Translate(Vector2.down * Time.fixedDeltaTime * speed);
                    break;
            }
        }

        if(IsMoveTo && isMoving && !IsRotate)
        {
            transform.position = new Vector2(x, y);
        }

        if(IsRotate && isMoving)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,z), Time.deltaTime * RotatinSpeed);
        }
    }
}
