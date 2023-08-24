using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingFloorScript : MonoBehaviour
{
  public PlayerController refToPlayerControls;
  private bool tutHasPlayed;
  private DialogueTrigger RefToDialogueTrigger;
  // Start is called before the first frame update
  void Start()
  {
    RefToDialogueTrigger = this.GetComponent<DialogueTrigger>();
        refToPlayerControls = FindObjectOfType<PlayerController>();
  }
  void OnCollisionEnter2D(Collision2D other)
  {
    tutHasPlayed = true;
    if (other.gameObject.CompareTag("Player"))
    {
      if (RefToDialogueTrigger != null)
      {
        if (tutHasPlayed)
        {
          RefToDialogueTrigger.TriggerDialogue();
          Destroy(RefToDialogueTrigger);
        }
      }

    }

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
