using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public DialogueTrigger RefToDiaTrigger;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        RefToDiaTrigger.TriggerDialogue();
        Destroy(RefToDiaTrigger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
