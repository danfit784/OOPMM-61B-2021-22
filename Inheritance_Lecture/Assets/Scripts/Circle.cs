using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D circlerb = this.gameObject.GetComponent<Rigidbody2D>();
        base.MoveLeft(circlerb, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
