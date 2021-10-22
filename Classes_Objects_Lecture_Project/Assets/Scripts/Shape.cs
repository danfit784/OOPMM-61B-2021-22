using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public float xpos, ypos;
    public Vector2 speed;
    // Start is called before the first frame update
    
    public Shape(float _xpos, float _ypos, float _speed)
    {
        xpos = _xpos;
        ypos = _ypos;
        speed = new Vector2(_speed,0);
    }

    public void MoveLeft(Rigidbody2D rb)
    {
        rb.velocity = -speed;
    }

    public void MoveRight(Rigidbody2D rb)
    {
        rb.velocity = speed;
    }


}
