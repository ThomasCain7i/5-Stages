using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    private DialogueTrigger RefToDialogueTrigger;
     public PlayerController refToPlayerControls;
     public GameObject refToBargainMenu;
    // Start is called before the first frame update
    void Start()
    {
         RefToDialogueTrigger = this.GetComponent<DialogueTrigger>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
         RefToDialogueTrigger.TriggerDialogue();
    }

    void OnTriggerStay2D(Collider2D other)
   {
     if (other.gameObject.CompareTag("Player") && refToPlayerControls.isInteracting)
        {
           
            StartCoroutine(waitAFewSeconds());
             
        }
   }

    IEnumerator waitAFewSeconds()
    {
        yield return new WaitForSeconds(1f);
        refToBargainMenu.SetActive(true);
    }
}
