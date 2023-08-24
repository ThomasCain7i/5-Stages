using UnityEngine;

public class PolaroidsPaused : MonoBehaviour
{
    [Header("Polaroids")]
    [SerializeField]
    private GameObject denial;
    [SerializeField]
    private GameObject anger, bargaining, depression, acceptance, final;

    [Header("Polaroids Big")]
    [SerializeField]
    private GameObject denialBig;
    [SerializeField]
    private GameObject angerBig, bargainingBig, depressionBig, acceptanceBig, finalBig;

    [Header("Refs")]
    PauseMenu pauseMenu;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = FindObjectOfType<PauseMenu>();
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseMenu.isPaused)
        {
            if (playerController.denial == 1)
            {
                denial.SetActive(true);
            }

            if (playerController.anger == 1)
            {
                anger.SetActive(true);
            }

            if (playerController.bargaining == 1)
            {
                bargaining.SetActive(true);
            }

            if (playerController.depression == 1)
            {
                depression.SetActive(true);
            }

            if (playerController.acceptance == 1)
            {
                acceptance.SetActive(true);
            }

            if (playerController.final == 1)
            {
                final.SetActive(true);
            }
        }
    }

    public void ClosePolaroid()
    {
        denialBig.SetActive(false);
        angerBig.SetActive(false);
        bargainingBig.SetActive(false);
        depressionBig.SetActive(false);
        acceptanceBig.SetActive(false);
        finalBig.SetActive(false);
        pauseMenu.pauseMenuUI.SetActive(true);
    }

    public void OpenDenial()
    {
        denialBig.SetActive(true);
        pauseMenu.pauseMenuUI.SetActive(false);
    }

    public void OpenAnger()
    {
        angerBig.SetActive(true);
        pauseMenu.pauseMenuUI.SetActive(false);
    }

    public void OpenBargaining()
    {
        bargainingBig.SetActive(true);
        pauseMenu.pauseMenuUI.SetActive(false);
    }

    public void OpenDepression()
    {
        depressionBig.SetActive(true);
        pauseMenu.pauseMenuUI.SetActive(false);
    }

    public void OpenAcceptance()
    {
        acceptanceBig.SetActive(true);
        pauseMenu.pauseMenuUI.SetActive(false);
    }

    public void OpenFinal()
    {
        finalBig.SetActive(true);
        pauseMenu.pauseMenuUI.SetActive(false);
    }
}
