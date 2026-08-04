using UnityEngine;

public class WolfMovement : MonoBehaviour
{
    public Rigidbody2D wolfRb;
    public float speed = 5f;

    void Awake()
    {
        wolfRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        wolfRb.linearVelocity = Vector2.left * speed;
    }
}
 