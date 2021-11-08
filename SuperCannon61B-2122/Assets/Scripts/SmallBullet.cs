using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : MonoBehaviour
{
    Vector2 direction;
    float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentmousePos = GameData.GetMousePos();
        direction = new Vector2(currentmousePos.x, currentmousePos.y +5f);
        direction.Normalize();
        this.gameObject.GetComponent<Rigidbody2D>().velocity = direction *speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
