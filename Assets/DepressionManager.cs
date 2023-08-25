using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepressionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject text1, text2, text3, text4, text5, text6, text7, monster;

    [SerializeField]
    private bool one, two, three, four, five, six, seven, crack1, crack2, timerB;

    [SerializeField]
    private float timer = 5f;

    [SerializeField]
    Animator animator;

    private void Update()
    {
        if (timerB == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (one)
            {
                text1.SetActive(true);
                timerB = true;
            }

            if (two)
            {
                text2.SetActive(true);
                timerB = true;
            }

            if (three)
            {
                text3.SetActive(true);
                timerB = true;
            }

            if( four)
            {
                text4.SetActive(true);
                timerB = true;
            }

            if (five)
            {
                text5.SetActive(true);
                timerB = true;
            }

            if (six)
            {
                text6.SetActive(true);
                timerB = true;
            }

            if (seven)
            {
                text7.SetActive(true);
                timerB = true;
                Destroy(monster);
            }

            if (crack1)
            {
                animator.SetBool("Crack1", true);
                Debug.Log("Crack 1");
            }

            if (crack2)
            {
                animator.SetBool("Crack2", true);
            }
        }
    }
}
