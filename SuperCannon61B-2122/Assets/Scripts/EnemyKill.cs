using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour, ITakeDamage
{
    public int health {get; set;}

    public void TakeDamage(int damageAmount)
    {
        GameManager._instance.IncreaseScore(10);
        Destroy(this.gameObject);
    }

}
