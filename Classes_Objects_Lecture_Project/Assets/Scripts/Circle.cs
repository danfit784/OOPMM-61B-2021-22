using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 speed = new Vector2(-2f, 0f);

        Shape mycircle = new Shape(0f, -3f, 2f); 


        Rigidbody2D circleRB = this.gameObject.GetComponent<Rigidbody2D>();
        mycircle.MoveLeft(circleRB);
     
    }


}
