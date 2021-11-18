using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTracker : MonoBehaviour
{
	private bool _facingLeft = false;

	public static Vector2 direction;
    
    private void Update()
    {	
    	Vector3 scale = transform.localScale;

        var mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var angle = Vector2.Angle(Vector2.right,mousePosition-transform.position);

        direction = mousePosition;
        direction.Normalize();

        if(angle > 90 && !_facingLeft)
        {
        	scale.y *= -1;
        	transform.localScale = scale;
        	_facingLeft = true;
        }

        if (angle < 90 && _facingLeft) 
        {
        	scale.y *= -1;
        	transform.localScale = scale;
        	_facingLeft = false;
        }
        transform.eulerAngles = new Vector3(0,0,transform.position.y < mousePosition.y ? angle : -angle);
        	

    }
}
