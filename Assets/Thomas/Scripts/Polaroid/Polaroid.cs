using UnityEngine;

public class Polaroid : MonoBehaviour
{
    [Header("Polaroids")]
    public bool denial, anger, bargaining, depression, acceptance;

    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(denial)
            {
                playerController.denial = 1;
                Destroy(gameObject);
            }

            if (anger)
            {
                playerController.anger = 1;
                Destroy(gameObject);
            }

            if (bargaining)
            {
                playerController.bargaining = 1;
                Destroy(gameObject);
            }

            if (depression)
            {
                playerController.depression = 1;
                Destroy(gameObject);
            }

            if (acceptance)
            {
                playerController.acceptance = 1;
                Destroy(gameObject);
            }
        }
    }
}
