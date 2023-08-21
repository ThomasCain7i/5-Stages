using UnityEngine;

public class ConstantMovingEnemy : MonoBehaviour
{
    public float moveSpeed = 3f; // Adjust this to control the enemy's movement speed

    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.SetParent(player);
    }

    private void Update()
    {
        // Calculate the direction from the enemy to the player
        Vector2 directionToPlayer = (player.position - transform.position).normalized;

        // Calculate the target position for the enemy to move towards the player
        Vector2 targetPosition = (Vector2)transform.position + directionToPlayer * moveSpeed * Time.deltaTime;

        // Move the enemy towards the player
        transform.position = targetPosition;
    }
}
