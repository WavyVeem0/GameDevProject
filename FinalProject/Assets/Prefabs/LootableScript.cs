using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootableScript : MonoBehaviour
{
	public PlayerStats player;
   

    public string name;
    public int id;
    [SerializeField]public int number;

    private void Start() 
    {
    	player = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
    	if(other.CompareTag("Player")) 
    	{
    		player.AddThing(id,name,number);
    		Destroy(gameObject);
    	}
    }
}
