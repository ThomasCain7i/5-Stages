using UnityEngine;
using System.Collections;

public class ThemeManager : MonoBehaviour
{
    [Header("What Level")]
    public bool menu;
    public bool denial, anger, bargaining, depression, acceptance;

    [Header("Audio Clips")]

    [Header("Theme Music")]
    public AudioClip[] menuTheme;
    public AudioClip[] denialTheme;
    public AudioClip[] angerTheme;
    public AudioClip[] bargainingTheme;
    public AudioClip[] depressionTheme;
    public AudioClip[] acceptanceTheme;

    [Header("Volume")]
    [SerializeField]
    private float VolumeMenu;
    [SerializeField]
    private float VolumeDenial, VolumeAnger, VolumeBargaining, VolumeDepression, VolumeAcceptance;

    [Header("Fade")]
    [SerializeField]
    private float fadeDuration;

    [Header("References")]
    [SerializeField]
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        PlayThemeMusic();
    }

    public void PlayThemeMusic()
    {
        if (menuTheme.Length > 0 && menu == true)
        {
            int randomIndex = Random.Range(0, menuTheme.Length);
            audioSource.clip = menuTheme[randomIndex];
            audioSource.volume = VolumeMenu;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Play theme");
        }

        if (denialTheme.Length > 0 && denial == true)
        {
            int randomIndex = Random.Range(0, denialTheme.Length);
            audioSource.clip = denialTheme[randomIndex];
            audioSource.volume = VolumeDenial;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Play theme");
        }

        if (angerTheme.Length > 0 && anger == true)
        {
            int randomIndex = Random.Range(0, angerTheme.Length);
            audioSource.clip = angerTheme[randomIndex];
            audioSource.volume = VolumeAnger;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Play theme");
        }

        if (bargainingTheme.Length > 0 && bargaining == true)
        {
            int randomIndex = Random.Range(0, bargainingTheme.Length);
            audioSource.clip = bargainingTheme[randomIndex];
            audioSource.volume = VolumeBargaining;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Play theme");
        }

        if (depressionTheme.Length > 0 && depression == true)
        {
            int randomIndex = Random.Range(0, depressionTheme.Length);
            audioSource.clip = depressionTheme[randomIndex];
            audioSource.volume = VolumeDepression;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Play theme");
        }

        if (acceptanceTheme.Length > 0 && acceptance == true)
        {
            int randomIndex = Random.Range(0, acceptanceTheme.Length);
            audioSource.clip = acceptanceTheme[randomIndex];
            audioSource.volume = VolumeAcceptance;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Play theme");
        }
    }

    public IEnumerator FadeOutAudio()
    {
        Debug.Log("Fading Out");

        float startTime = Time.time;

        while (Time.time - startTime < fadeDuration)
        {
            float elapsed = Time.time - startTime;
            float t = elapsed / fadeDuration;

            audioSource.volume = Mathf.Lerp(VolumeDepression, 0.0f, t);
            yield return null;
        }

        // Ensure the volume reaches the exact target value
        audioSource.volume = 0.0f;
    }
}