using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAttack : MonoBehaviour
{
    public int damage = 25;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TowerHealth tower = collision.gameObject.GetComponent<TowerHealth>();

        if (tower != null)
        {
            tower.health -= damage;
            Destroy(gameObject);
        }
    }
}