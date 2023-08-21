using UnityEngine;

public class SceneStartAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    public PlayerController playerController; // Assign in the Inspector

    private void Start()
    {
        animator = GetComponent<Animator>();
        if (animator != null)
        {
            // Trigger the animation (if using a trigger parameter)
            animator.SetTrigger("StartAnimation");

            // Disable player controls during animation
            if (playerController != null)
            {
                playerController.SetAnimationPlaying(true);
            }
        }
    }

    // Method to be called by animation event when animation is done
    public void AnimationFinished()
    {
        // Enable player controls after animation
        if (playerController != null)
        {
            playerController.SetAnimationPlaying(false);
        }
    }
}