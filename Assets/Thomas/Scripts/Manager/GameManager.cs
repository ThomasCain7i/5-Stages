using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    public PlayerController playerController;

    [Header("Polaroids")]
    public int denial, anger, bargaining, depression, acceptance, final;
    private const string denialKey = "denial";
    private const string angerKey = "anger";
    private const string bargainingKey = "bargaining";
    private const string depressionKey = "depression";
    private const string acceptanceKey = "acceptance";


    public void Start()
    {
        if (playerController != null)
        {
            playerController = FindObjectOfType<PlayerController>();
        }


        LoadSettings();
    }

    public void SavePolaroid()
    {
        PlayerPrefs.SetInt(denialKey, denial);
        PlayerPrefs.SetInt(angerKey, anger);
        PlayerPrefs.SetInt(bargainingKey, bargaining);
        PlayerPrefs.SetInt(depressionKey, depression);
        PlayerPrefs.SetInt(acceptanceKey, acceptance);
        PlayerPrefs.Save();

        Debug.Log("Saved Polaroids");
    }

    public void LoadSettings()
    {


        denial = PlayerPrefs.GetInt("denial");
        anger = PlayerPrefs.GetInt("anger");
        bargaining = PlayerPrefs.GetInt("bargaining");
        depression = PlayerPrefs.GetInt("depression");
        acceptance = PlayerPrefs.GetInt("acceptance");

        Debug.Log("Loaded Polaroids");


    }

    public void ResetProgress()
    {
        // Rester all saves
        PlayerPrefs.DeleteAll();

        Debug.Log("Reset Polaroids");
    }
}