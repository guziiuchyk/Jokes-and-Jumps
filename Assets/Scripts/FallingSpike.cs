using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    [SerializeField] public bool isMoving = false;
    [SerializeField] bool IsMoveTo = false;
    [SerializeField] int x = 0;
    [SerializeField] int y = 0;
    public float speed = 6f;
    public enum Orientation
    {
        Left,
        Right,
        Up,
        Down
    }

    public Orientation orientation;
    private void FixedUpdate()
    {
        if (isMoving && !IsMoveTo)
        {
            switch (orientation)
            {
                case Orientation.Left:
                    transform.Translate(Vector2.left * Time.fixedDeltaTime * speed);
                    break;
                case Orientation.Right:
                    transform.Translate(Vector2.right * speed);
                    break;
                case Orientation.Up:
                    transform.Translate(Vector2.up * Time.fixedDeltaTime * speed);
                    break;
                case Orientation.Down:
                    transform.Translate(Vector2.down * Time.fixedDeltaTime * speed);
                    break;
            }
        }
        if(IsMoveTo && isMoving)
        {
            transform.position = new Vector2(x, y);
        }
    }
}
