using UnityEngine.InputSystem;
using UnityEngine;

public class SwordSpawner : MonoBehaviour
{
    public GameObject swordPrefab;
    public float coolDown = 0.5f;

    private float timer;

    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        // Reduce cooldown timer
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        // Fire sword when Left Mouse Button is clicked
        if (Mouse.current.leftButton.wasPressedThisFrame && timer <= 0)
        {
            Instantiate(swordPrefab, transform.position, Quaternion.identity);

            // Reset cooldown
            timer = coolDown;
        }
    }
}