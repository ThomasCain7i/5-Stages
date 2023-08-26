using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BargainingMenuScript : MonoBehaviour
{
    public GameObject KeyPanel, LocketPanel, CameraPanel, ShellPanel, RingPanel;
    bool youMadeTheRightChoice;

    [SerializeField]
    Animator animator;

    public void Shell()
    {
        youMadeTheRightChoice = true;
        ShellPanel.SetActive(true);
        KeyPanel.SetActive(false);
        LocketPanel.SetActive(false);
        CameraPanel.SetActive(false);
        RingPanel.SetActive(false);

        if (youMadeTheRightChoice)
        {
            WaitForACoupleSecs();
        }
    }

    public void Key()
    {
        KeyPanel.SetActive(true);
    }

    public void Ring()
    {
        RingPanel.SetActive(true);
    }

    public void Locket()
    {
        LocketPanel.SetActive(true);
    }

    public void Camera()
    {
        CameraPanel.SetActive(true);
    }


    public void Closebox()
    {
        ShellPanel.SetActive(false);
        KeyPanel.SetActive(false);
        LocketPanel.SetActive(false);
        CameraPanel.SetActive(false);
        RingPanel.SetActive(false);
    }

    private void WaitForACoupleSecs()
    {
        animator.SetBool("Shell", true);
    }
}
