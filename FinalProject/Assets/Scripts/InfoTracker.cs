using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTracker : MonoBehaviour
{
	public GameObject player;
	public GameObject gun;
	public Canvas canv;
	public Text tracker;

	private void OnTriggerEnter2D(Collider2D other)
	{
		player.GetComponent<Movement>().enabled = false;
		gun.GetComponent<GunShoot>().enabled = false;
		gun.GetComponent<GunTracker>().enabled = false;
		canv.enabled = true;
		Info();

	}

    private void Info() 
    {
    	foreach (Loot elem in player.GetComponent<PlayerStats>().inventory) 
    	{
    		tracker.text += elem.name + "\n";
    	}
    }
}
