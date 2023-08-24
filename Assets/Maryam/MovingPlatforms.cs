using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 1.5f;
    int direction = 1;

    private void Update()
    {
        Vector2 target = currentMovementTarget();

        platform.position = Vector2.Lerp(platform.position,target,speed*Time.deltaTime);
        
        float distance=(target-(Vector2)platform.position).magnitude;

        if (distance <= 1f)
        {
            direction *= -1;
        }
    }

    Vector2 currentMovementTarget()
    {
        if (direction == 1)
        {
            return startPoint.position;
        }
        else 
        {
            return endPoint.position;
        
        }
    }

    private void OnDrawGizmos()
    {
        //just for Debug visualization
        if(platform!= null && startPoint!=null && endPoint!=null)
        {
            Gizmos.DrawLine(platform.transform. position, startPoint.transform.position);
            Gizmos.DrawLine(platform.transform.position, endPoint.transform.position);
        }
    }
}
