using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    ITakeDamage damageable;

    // Start is called before the first frame update
    void Start()
    {
        damageable = GetComponent<ITakeDamage>();
        damageable.health = 3;
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

            damageable.TakeDamage(1);
            
           
        }


    }



}
