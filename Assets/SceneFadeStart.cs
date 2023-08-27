using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFadeStart : MonoBehaviour
{
    [SerializeField]
    Animator animator;

    [SerializeField]
    bool denial, anger, bargaining, depression, acceptance;

    public void Start()
    {
        if (denial)
        {
            animator.SetBool("denial", true);
        }

        if (anger)
        {
            animator.SetBool("anger", true);
        }

        if (bargaining)
        {
            animator.SetBool("bargaining", true);
        }

        if (depression)
        {
            animator.SetBool("depression", true);
        }

        if (acceptance)
        {
            animator.SetBool("acceptance", true);
        }
    }

    public void DenialFade()
    {
        animator.SetBool("denial", false);
    }

    public void AngerFade()
    {
        animator.SetBool("anger", false);
    }

    public void BargainingFade()
    {
        animator.SetBool("bargaining", false);
    }

    public void DepressionFade()
    {
        animator.SetBool("depression", false);
    }

    public void AcceptanceFade()
    {
        animator.SetBool("acceptance", false);
    }
}
