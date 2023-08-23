using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifeSoulTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject wifeSpawn, wifeDelete, levelSpawn, levelDelete;

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
            if(wifeSpawn != null)
            {
                wifeSpawn.SetActive(true);
            }

            if(wifeDelete != null)
            {
                wifeDelete.SetActive(false);
            }

            if (levelSpawn != null)
            {
                levelSpawn.SetActive(true);
            }

            if (levelDelete != null)
            {
                levelDelete.SetActive(false);
            }

        }
    }
}
