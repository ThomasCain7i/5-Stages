using UnityEngine;

public class WifeFade : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void FadeWife()
    {
        animator.SetTrigger("WifeFade");
    }

    public void WifeDelete()
    {
        Destroy(gameObject);
    }
}