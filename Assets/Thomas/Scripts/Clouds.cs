using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Move left by setting the velocity of the Rigidbody2D
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
    }
}
