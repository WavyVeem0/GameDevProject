using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTracker : MonoBehaviour
{
	public Image pan;
	public GameObject player;
	public GameObject gun;
	public Canvas canv;
	public Text tracker;

	private void OnTriggerEnter2D(Collider2D other)
	{
		OffAll();
		Info(false);
		DataHolder.playerLastHp = player.GetComponent<PlayerStats>().health;

	}
	public void OffAll() 
	{
		player.GetComponent<Movement>().enabled = false;
		gun.GetComponent<GunShoot>().enabled = false;
		gun.GetComponent<GunTracker>().enabled = false;
		canv.enabled = true;
	}

    public void Info(bool isDead) 
    {
    	foreach (Loot elem in player.GetComponent<PlayerStats>().inventory) 
    	{
    		tracker.text += elem.name + " x" + elem.number + " \n";
    
    		if (elem.name == "Metal")
    		{
    			DataHolder.totalMetal += elem.number;
    		}
    	}
    	if(isDead) 
    	{
    		pan.color = new Color(140,0,0);
    	}
    	
    }
}
