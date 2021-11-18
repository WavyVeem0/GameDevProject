using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	[SerializeField]
	private bool _isInside = false;
	private BoxCollider2D collider;

	private void Awake() 
	{
		collider = GetComponent<BoxCollider2D>();
		print(collider);
	}
   
    private void OnTriggerEnter(Collider other) 
    {
    	_isInside = true;
    	print("UwU");
    }
    private void OnTriggerExit() 
    {
    	if(_isInside) 
    	{
    		collider.isTrigger = false;
    	}

    }
}
