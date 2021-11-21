using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
	public HealthScript hpBar;
    public int health = 100;
    public int mentalHealth = 100;
    public List<Loot> inventory = new List<Loot>();

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
    	hpBar.SetHealth(health);
    }

    public void AddThing(int id, string name) 
    {
    	Loot obj = new Loot();
    	obj.id = id;
    	obj.name = name;
    	inventory.Add(obj);
    } 
}
