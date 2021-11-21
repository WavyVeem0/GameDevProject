using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
	public InfoTracker tracker;
	public HealthScript hpBar;
    public int health = 100;
    public int mentalHealth = 100;
    public List<Loot> inventory = new List<Loot>();

    private void Awake() 
    {
    	health = DataHolder.playerLastHp;
    }

    private void Update() 
    {
    	if(health <= 0) 
    	{
    		
    		gameObject.transform.localScale = Vector3.zero;
    		DataHolder.playerLastHp = 0;
    		tracker.OffAll();
    		tracker.Info(true);
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
