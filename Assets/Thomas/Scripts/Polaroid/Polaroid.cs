using UnityEngine;
using UnityEngine.SceneManagement;

public class Polaroid : MonoBehaviour
{
    [Header("Polaroids")]
    public bool denial;
    public bool anger, bargaining, depression, acceptance, final;

    [Header("Destroy Object")]
    [SerializeField]
    private GameObject Floor;
    private GameManager gameManager;


    private void Start()
    {
        
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if(denial)
            {
                gameManager.denial = 1;
                gameManager.SavePolaroid();

                if(Floor  != null)
                {
                    Destroy(Floor);
                }

                Destroy(gameObject);
            }

            if (anger)
            {
                gameManager.anger = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (bargaining)
            {
                gameManager.bargaining = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (depression)
            {
                gameManager.depression = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (acceptance)
            {
                gameManager.acceptance = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }

            if (final)
            {
                gameManager.final = 1;
                gameManager.SavePolaroid();
                Destroy(gameObject);
            }
        }
    }
}
