using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifeSoulTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject wife;

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

        }
    }
}
