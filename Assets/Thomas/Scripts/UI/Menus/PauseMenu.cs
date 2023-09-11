using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;

    public GameObject pauseMenuUI, areYouSureUI, Main;
    public PolaroidsPaused RefToPolaroidPause;

    [SerializeField]
    private LevelLoader levelLoader;
     void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        Debug.Log("Hi Hi");
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        RefToPolaroidPause.pauseMenu = FindObjectOfType<PauseMenu>();
        RefToPolaroidPause.gameManager = FindObjectOfType<GameManager>();


    }
    private void OnDestroy()
    {
        // Unsubscribe from the sceneLoaded event to prevent memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (SceneManager.GetActiveScene().buildIndex != 0))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
     
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void AreYouSure()
    {
        Main.SetActive(false);
        areYouSureUI.SetActive(true);
    }

    public void NotSure()
    {
        areYouSureUI.SetActive(false);
        Main.SetActive(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        Resume();
    }

}