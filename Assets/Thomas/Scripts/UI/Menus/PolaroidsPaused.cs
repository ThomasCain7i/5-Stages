using UnityEngine;
using UnityEngine.SceneManagement;

public class PolaroidsPaused : MonoBehaviour

{
    [Header("Polaroids")]
    [SerializeField]
    private GameObject refToAnger, refToDenial, refToBargaining, refToDepression, refToAcceptance, refToFinal;

    [Header("Polaroids Big")]
    [SerializeField]
    private GameObject denialBig;
    [SerializeField]
    private GameObject angerBig, bargainingBig, depressionBig, acceptanceBig, finalBig;

    [Header("Refs")]
    public PauseMenu pauseMenu;
    public GameManager gameManager;
   
   
     void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        Debug.Log("Has been enabled");
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        pauseMenu = FindObjectOfType<PauseMenu>();
        gameManager = FindObjectOfType<GameManager>();


    }
    private void OnDestroy()
    {
        // Unsubscribe from the sceneLoaded event to prevent memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (pauseMenu != null)
        {
            if (pauseMenu.isPaused)
            {
                if (gameManager.denial == 1)
                {
                    refToDenial.SetActive(true);
                }

                if (gameManager.anger == 1)
                {
                    refToAnger.SetActive(true);
                }

                if (gameManager.bargaining == 1)
                {
                    refToBargaining.SetActive(true);
                }

                if (gameManager.depression == 1)
                {
                    refToDepression.SetActive(true);
                }

                if (gameManager.acceptance == 1)
                {
                    refToAcceptance.SetActive(true);
                }

                if (gameManager.final == 1)
                {
                    refToFinal.SetActive(true);
                }
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
