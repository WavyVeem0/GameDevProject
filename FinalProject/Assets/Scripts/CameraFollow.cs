using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followObj;
    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 dest;
       	dest = followObj.transform.position;
       	dest = Vector3.Lerp(transform.position,dest,Time.deltaTime*2);
        dest.z = -10; 
   		transform.position = dest;
    }
}
