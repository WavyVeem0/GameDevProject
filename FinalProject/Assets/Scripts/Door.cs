using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	
	public List<Enemy> roomEnemy = new List<Enemy>(); 

	[SerializeField]private bool _isInside = false;
	private BoxCollider2D collider;

	private void Awake() 
	{
		collider = GetComponent<BoxCollider2D>();
		collider.enabled = false;
	}

    private void Update() 
    {
    	if(roomEnemy.Count <= 0)
    	{
    		_isInside = false;
    		collider.enabled = false;
    	}
    }


}
