// Thomas

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject mainMenu, creditsMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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