using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Sword collided with: " + collision.name);//it print message in unity console 

        Destroy(collision.gameObject); //it destroy wolf
        Destroy(gameObject);           //it destroy sword
    }
}