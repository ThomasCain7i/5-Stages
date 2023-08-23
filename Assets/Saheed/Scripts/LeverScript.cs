using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [SerializeField] GameObject disappearingFloor;
    public PlayerController refToPlayerControls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player") && refToPlayerControls.isInteracting)
        {
            disappearingFloor.SetActive(false);   
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if ( refToPlayerControls.isInteracting)
        {
            disappearingFloor.SetActive(false);   
        }
    }
    void Update()
    {
       
    }
    IEnumerator floorCollapseTimer() // What happens when you press the interact key
    {
        Debug.Log("Test");
        yield return new WaitForSeconds(0.1f);
        disappearingFloor.SetActive(false);
       
    }
}
