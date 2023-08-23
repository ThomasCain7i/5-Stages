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
           leverFloorOpener();
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if ( refToPlayerControls.isInteracting)
        {
           leverFloorOpener();
        }
    }
    void Update()
    {
       
    }
    void leverFloorOpener()
    {
        disappearingFloor.SetActive(false);   
    }
}
