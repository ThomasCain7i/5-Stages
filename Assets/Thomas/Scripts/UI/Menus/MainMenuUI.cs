// Thomas

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject mainMenu, creditsMenu;

    public LevelLoader levelLoader;

    public void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    public void PlayGame()
    {
        levelLoader.LoadLevel(1);
    }

    public void OpenCredits()
    {
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void CloseOptions()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}