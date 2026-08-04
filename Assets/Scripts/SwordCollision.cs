using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Sword collided with: " + collision.name);

        Destroy(collision.gameObject); // Destroy Wolf
        Destroy(gameObject);           // Destroy Sword
    }
}