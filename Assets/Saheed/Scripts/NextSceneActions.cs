using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextSceneActions : MonoBehaviour
{
     public void OnCollisionEnter2D(Collision2D other)
    {
       
            StartCoroutine(NextSceneLoader());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      
     IEnumerator NextSceneLoader()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }   
   
}
