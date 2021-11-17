using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    public float speed = 5f;
    public GameObject gun;
    public Vector3 pos;
    public static bool facingRight = true;

    void Awake()
    {
    	pos = gameObject.transform.position;
        gun = GameObject.Find("gun");
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)) 
        {
        	pos += Vector3.up;
        	gameObject.transform.position = pos*Time.fixedDeltaTime*speed;

        }

        if(Input.GetKey(KeyCode.A))
        {
        	if(facingRight)
        	{
        		Vector3 gunScale = gun.transform.localScale;
				Vector3 scale = transform.localScale;
				gunScale.x *= -1;
        		scale.x *= -1;
        		gun.transform.localScale = gunScale;
        		transform.localScale = scale;
        		facingRight = !facingRight;
        	}

        	pos += Vector3.left;
        	transform.position = pos*Time.fixedDeltaTime*speed;
        	
         }

        if(Input.GetKey(KeyCode.S)) 
        {
        	pos += Vector3.down;
        	transform.position = pos*Time.fixedDeltaTime*speed;
        }

        if (Input.GetKey(KeyCode.D)) 
        {
        	pos += Vector3.right;
        	transform.position = pos*Time.fixedDeltaTime*speed;
        	if(!facingRight)
        	{
        		Vector3 gunScale = gun.transform.localScale;
				Vector3 scale = transform.localScale;
        		scale.x *= -1;
        		gunScale.x *= -1;
        		transform.localScale = scale;
        		gun.transform.localScale = gunScale;
        		facingRight = !facingRight;
        	}
        }


    }


}
