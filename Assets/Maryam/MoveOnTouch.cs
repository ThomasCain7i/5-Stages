using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;

    [SerializeField]
    private bool moving;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moving = true;
            collision.transform.SetParent(transform);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

    private void Update()
    {
        Debug.Log("updating");
        if (moving)
        {
            transform.position += (velocity * Time.deltaTime);
            moving = false;
        }
    }


}
