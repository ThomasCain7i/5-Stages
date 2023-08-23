using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingFloorScript : MonoBehaviour
{
    public PlayerController refToPlayerControls;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void OnCollisionStay2D(Collision2D other)
   {
     if (other.gameObject.CompareTag("Player") && refToPlayerControls.isInteracting)
        {
           BreakFloor();
        }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BreakFloor()
    {
        this.gameObject.SetActive(false);  
    }
}
