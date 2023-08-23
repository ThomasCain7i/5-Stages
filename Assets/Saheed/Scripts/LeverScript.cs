using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [SerializeField] GameObject disappearingFloor;
    public PlayerController refToPlayerControls;
    private DialogueTrigger RefToDialogueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        RefToDialogueTrigger = this.GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
   void OnTriggerStay2D(Collider2D other)
   {
     if (other.gameObject.CompareTag("Player") && refToPlayerControls.isInteracting)
        {
            RefToDialogueTrigger.TriggerDialogue();
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
