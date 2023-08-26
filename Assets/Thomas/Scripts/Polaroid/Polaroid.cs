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

    private GameManager gameManager;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(denial)
            {
                playerController.denial = 1;
                gameManager.SavePolaroid();

                if(Floor  != null)
                {
                    Destroy(Floor);
                }

                Destroy(gameObject);
            }

            if (anger)
            {
                playerController.anger = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (bargaining)
            {
                playerController.bargaining = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (depression)
            {
                playerController.depression = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (acceptance)
            {
                playerController.acceptance = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }
        }
    }
}
