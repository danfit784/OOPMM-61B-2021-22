using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.name.Contains("Bullet"))
        {
            Destroy(other.gameObject);

            //TO DO SCORE CHANGE

            GameManager._instance.IncreaseScore(10);

            Destroy(this.gameObject);
            
           
        }


    }



}
