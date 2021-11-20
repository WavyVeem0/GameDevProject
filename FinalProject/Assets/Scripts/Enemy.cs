using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Door door;
    public GameObject player;


    
    private void Update() 
    {
    	if(health <= 0) 
    	{
            door.roomEnemy.Remove(this);
    		Destroy(gameObject);
    	}
    }

    private void FixedUpdate() 
    {
        if (door.GetComponent<Collider2D>().enabled) 
        {
            //Debug.Log("111");
        }
    }

    public void TakeDamage(int dmg) 
    {
        health -= dmg;
    } 


}