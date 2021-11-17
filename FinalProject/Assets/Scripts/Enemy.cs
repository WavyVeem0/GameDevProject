using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int dmg) 
    {
    	health -= dmg;
    } 

    private void Update() 
    {
    	if(health <= 0) 
    	{
    		Destroy(gameObject);
    	}
    }

}