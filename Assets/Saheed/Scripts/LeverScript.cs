using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    [SerializeField] GameObject disappearingFloor;
    public PlayerController refToPlayerControls;
    private DialogueTrigger RefToDialogueTrigger;
    bool DialogueTrig;
    public Sprite LeverActivated, defaultSprite;
    // Start is called before the first frame update
    void Start()
    {
        RefToDialogueTrigger = this.GetComponent<DialogueTrigger>();
        defaultSprite = GetComponentInChildren<SpriteRenderer>().sprite;
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (!DialogueTrig)
        {
            RefToDialogueTrigger.TriggerDialogue();
        }
        else if (DialogueTrig)
        {
           
        }

        if (other.gameObject.CompareTag("Player"))
        {
            DialogueTrig = true;
           
        }
    }

    // Update is called once per frame
   void OnTriggerStay2D(Collider2D other)
   {
     if (other.gameObject.CompareTag("Player") && refToPlayerControls.isInteracting)
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
        defaultSprite = LeverActivated;
        GetComponentInChildren<SpriteRenderer>().sprite = defaultSprite;   
    }
}
