using UnityEngine;
using System.Collections;

public class DepressionFadeIn : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] depressionChaseTheme;
    public float VolumeAcceptance; // Initial volume for the fade-in
    public float fadeDuration; // Duration of the fade-in

    private void Start()
    {
        // Initialize audioSource if not assigned
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlayDepressionChase()
    {
        if (depressionChaseTheme.Length > 0)
        {
            int randomIndex = Random.Range(0, depressionChaseTheme.Length);
            audioSource.clip = depressionChaseTheme[randomIndex];
            audioSource.loop = true;
            audioSource.volume = 0.0f; // Start with volume set to 0

            audioSource.Play();
            StartCoroutine(FadeInAudio());
        }
    }

    private IEnumerator FadeInAudio()
    {
        float startTime = Time.time;

        while (Time.time - startTime < fadeDuration)
        {
            float elapsed = Time.time - startTime;
            float t = elapsed / fadeDuration;

            audioSource.volume = Mathf.Lerp(0.0f, VolumeAcceptance, t);
            yield return null;
        }

        // Ensure the volume reaches the exact target value
        audioSource.volume = VolumeAcceptance;
    }
}
