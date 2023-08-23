using UnityEngine;
using System.Collections;

public class DepressionTrigger : MonoBehaviour
{
    DepressionFadeIn depressionFadeIn;
    ThemeManager themeManager;

    // Start is called before the first frame update
    void Start()
    {
        depressionFadeIn = GetComponent<DepressionFadeIn>();
        themeManager = FindObjectOfType<ThemeManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(TriggeredRoutine());
        }
    }

    private IEnumerator TriggeredRoutine()
    {
        yield return StartCoroutine(themeManager.FadeOutAudio());
        depressionFadeIn.PlayDepressionChase();
    }
}
