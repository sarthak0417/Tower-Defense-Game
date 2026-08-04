using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Rigidbody2D swordRb;
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        swordRb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        swordRb.linearVelocity = Vector2.right * speed;
        
    }
}