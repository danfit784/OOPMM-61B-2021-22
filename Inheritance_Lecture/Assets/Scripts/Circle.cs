using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    [SerializeField] float _xspeed=1;
    [SerializeField] float _yspeed=1;
    [SerializeField] float _xpos = 0;
    [SerializeField] float _ypos = 0;

    Rigidbody2D circlerb;
    // Start is called before the first frame update
    protected override void Start()
    {
      // base.Start();
        xspeed = _xspeed;
        yspeed = _yspeed;
        xpos = _xpos;
        ypos = _ypos;
        this.gameObject.transform.position = new Vector3(xpos, ypos, 0f);
        circlerb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) base.MoveUp(circlerb);
        if (Input.GetKey(KeyCode.DownArrow)) base.MoveDown(circlerb);
        if (Input.GetKey(KeyCode.LeftArrow)) base.MoveLeft(circlerb);
        if (Input.GetKey(KeyCode.RightArrow)) base.MoveRight(circlerb);

    }
}
