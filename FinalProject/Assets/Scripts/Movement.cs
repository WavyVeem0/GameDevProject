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

    private Rigidbody2D _rb;

    private void Awake()
    {

    	pos = gameObject.transform.position;

        gun = GameObject.Find("gun");
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

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

         }

        if (Input.GetKey(KeyCode.D)) 
        {
        	
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

        _rb.velocity = new Vector2(horizontal,vertical).normalized * speed;
    }
}