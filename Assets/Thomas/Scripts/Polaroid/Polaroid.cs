using UnityEngine;

public class Polaroid : MonoBehaviour
{
    [Header("Polaroids")]
    public bool denial;
    public bool anger, bargaining, depression, acceptance;

    [Header("Destroy Object")]
    [SerializeField]
    private GameObject Floor;

    private PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(denial)
            {
                playerController.denial = 1;

                if(Floor  != null)
                {
                    Destroy(Floor);
                }

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
