using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    private DialogueTrigger RefToDialogueTrigger;
     public PlayerController refToPlayerControls;
    // Start is called before the first frame update
    void Start()
    {
         RefToDialogueTrigger = this.GetComponent<DialogueTrigger>();
    }
    void OnTriggerStay2D(Collider2D other)
   {
     if (other.gameObject.CompareTag("Player") && refToPlayerControls.isInteracting)
        {
            RefToDialogueTrigger.TriggerDialogue();
             
        }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
