using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    public PlayerController playerController;


    private const string denialKey = "denial";
    private const string angerKey = "anger";
    private const string bargainingKey = "bargaining";
    private const string depressionKey = "depression";
    private const string acceptanceKey = "acceptance";

    public void Start()
    {
        playerController = FindObjectOfType<PlayerController>();

        LoadSettings();
    }

    public void SavePolaroid()
    {
        PlayerPrefs.SetInt(denialKey, playerController.denial);
        PlayerPrefs.SetInt(angerKey, playerController.anger);
        PlayerPrefs.SetInt(bargainingKey, playerController.bargaining);
        PlayerPrefs.SetInt(depressionKey, playerController.depression);
        PlayerPrefs.SetInt(acceptanceKey, playerController.acceptance);
        PlayerPrefs.Save();

        Debug.Log("Saved Polaroids");
    }

    public void LoadSettings()
    {
        playerController.denial = PlayerPrefs.GetInt("despair");
        playerController.anger = PlayerPrefs.GetInt("anger");
        playerController.bargaining = PlayerPrefs.GetInt("bargaining");
        playerController.depression = PlayerPrefs.GetInt("depression");
        playerController.acceptance = PlayerPrefs.GetInt("acceptance");

        Debug.Log("Loaded Polaroids");
    }

    public void ResetProgress()
    {
        // Rester all saves
        PlayerPrefs.DeleteAll();

        Debug.Log("Reset Polaroids");
    }
}