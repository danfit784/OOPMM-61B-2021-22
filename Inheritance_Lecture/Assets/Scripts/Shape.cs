using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour   //this class will act as the base class for child classes (circle, diamond)
{

    protected void MoveLeft(Rigidbody2D rb, float xspeed)
    {
        Vector2 newspeed = new Vector2(xspeed, 0);
        rb.velocity = -newspeed;
    }

    protected void MoveRight(Rigidbody2D rb, float xspeed)
    {
        Vector2 newspeed = new Vector2(xspeed, 0);
        rb.velocity = newspeed;
    }


}

