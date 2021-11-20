using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health = 100;
    public int mentalHealth = 100;

    private void Update() 
    {
    	if(health <= 0) 
    	{
    		Destroy(gameObject);
    	}
    	if(mentalHealth <= 0)
    	{
    		GetComponent<Movement>().enabled = false;
    	}
    }


    public void TakeDamage(int dmg) 
    {
    	health -= dmg;
    }
}
