using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
	public GameObject door;

	private void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("smth");
		door.GetComponent<BoxCollider2D>().enabled = true;
		foreach (Enemy elem in door.GetComponent<Door>().roomEnemy) 
		{
			elem.enabled = true;
		}
	}
}
