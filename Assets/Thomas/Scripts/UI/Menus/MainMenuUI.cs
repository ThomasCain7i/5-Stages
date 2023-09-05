// Thomas

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject startMenu, mainMenu, creditsMenu, levelMenu, playAnim;

    public LevelLoader levelLoader;
    public GameManager refToGameManager;

    public void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
        refToGameManager = FindObjectOfType<GameManager>();
    }

    public void StartMenu()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
        startMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenPlayAnim()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(false);
        levelMenu.SetActive(false);
        playAnim.SetActive(true);
    }

    public void OpenLevelSelect()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
    }

    public void CloseLevelSelect()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
    }

    public void OpenCredits()
    {
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
        levelMenu.SetActive(false);
    }

    public void CloseOptions()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
    }

    public void DespairLevel()
    {
        if (refToGameManager.denial == 1)
        {
            levelLoader.LoadLevel(1);
        }

    }

    public void AngerLevel()
    {
        if (refToGameManager.anger == 1)
        {
            levelLoader.LoadLevel(2);
        }
    }

    public void BargainingLevel()
    {
        if (refToGameManager.bargaining == 1)
        {
            levelLoader.LoadLevel(3);
        }
    }

    public void DepressionLevel()
    {
        if (refToGameManager.depression == 1)
        {
            levelLoader.LoadLevel(4);
        }
    }

    public void AcceptanceLevel()
    {
        if (refToGameManager.acceptance == 1)
        {
            levelLoader.LoadLevel(5);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}