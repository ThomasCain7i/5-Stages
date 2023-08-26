using UnityEngine;

public class ConstantMovingEnemy : MonoBehaviour
{
    public float moveSpeed = 3f; // Adjust this to control the enemy's movement speed

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Get the player's y-axis position
        float targetY = player.position.y;

        // Calculate the target position for the enemy on the x-axis
        Vector2 targetPosition = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, targetY);

        // Move the enemy towards the target position
        transform.position = targetPosition;
    }
}

