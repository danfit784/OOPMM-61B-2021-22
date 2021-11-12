using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 direction;
    protected float speed = 1f;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        Vector3 currentmousePos = GameData.GetMousePos();
        direction = new Vector2(currentmousePos.x, currentmousePos.y + 5f);
        direction.Normalize();
        this.gameObject.GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    void Update()
    {
        if (this.gameObject.transform.position.y > GameData.GetYMax() + 1) Destroy(this.gameObject);
        if (this.gameObject.transform.position.y < GameData.GetYMin() - 1) Destroy(this.gameObject);
        if (this.gameObject.transform.position.x > GameData.GetXMax() + 1) Destroy(this.gameObject);
        if (this.gameObject.transform.position.x < GameData.GetXMin() - 1) Destroy(this.gameObject);
    }


}
