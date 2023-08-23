using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSoul : MonoBehaviour
{
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Touched Dark Soul");
        }
    }
}
