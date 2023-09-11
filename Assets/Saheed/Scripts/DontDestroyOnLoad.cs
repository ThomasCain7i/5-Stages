using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static GameObject instance;

    void Awake() {
    //Singleton method
    if (instance == null) {
        //First run, set the instance
        instance = this.gameObject;
        DontDestroyOnLoad(gameObject);
 
    } else if (instance != this) {
        //Instance is not the same as the one we have, destroy old one, and reset to newest one
        Destroy(instance.gameObject);
        instance = this.gameObject;
        DontDestroyOnLoad(gameObject);
    }
}
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
