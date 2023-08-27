using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneActions : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField]
    Animator animator;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.SavePolaroid();
            animator.SetBool("Shell", true);
        }
    }

    public void NextLevel()
    {
        gameManager.SavePolaroid();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StopAnimation()
    {
        animator.SetBool("Start", false);
    }
}
