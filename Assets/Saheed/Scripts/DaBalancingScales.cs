using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaBalancingScales : MonoBehaviour
{
    public HingeJoint2D hingejoint;
    public Transform[] objectsOnScale;
    

    private void Start()
    {
        hingejoint = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        float totalTorque = 0f;

        foreach (Transform obj in objectsOnScale) // weights of thingeys youre sticking on
        {
            float weight = obj.GetComponent<Rigidbody2D>().mass;
            float distance = obj.position.x - hingejoint.transform.position.x;
            totalTorque += weight * distance;
        }

       
    }
}
