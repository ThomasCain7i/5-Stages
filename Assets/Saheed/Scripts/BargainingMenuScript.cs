using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BargainingMenuScript : MonoBehaviour
{
    public GameObject refToWrongChoicePanel, refToRightChoicePanel;
    bool youMadeTheRightChoice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RightChoice()
    {
        youMadeTheRightChoice = true;
        refToRightChoicePanel.SetActive(true);
        refToWrongChoicePanel.SetActive(false);
        if (youMadeTheRightChoice)
        {
            StartCoroutine(WaitForACoupleSecs());
        }

    }
     public void WrongChoice()
    {
        refToWrongChoicePanel.SetActive(true);
        refToRightChoicePanel.SetActive(false);
    }
    public void Closebox()
    {
         refToWrongChoicePanel.SetActive(false);
        refToRightChoicePanel.SetActive(false);
    }
    IEnumerator WaitForACoupleSecs()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
