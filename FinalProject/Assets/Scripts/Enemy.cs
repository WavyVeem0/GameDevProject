using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Door door;
    public GameObject player;

    private Rigidbody2D _rb;

    private void Awake() 
    {
        _rb = GetComponent<Rigidbody2D>();
        this.enabled = false;
    }


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
        Vector2 playerPos = player.transform.position;
        Vector2 currentPos = transform.position;

        transform.position = Vector2.Lerp(currentPos,playerPos,Time.fixedDeltaTime);




    }

    public void TakeDamage(int dmg) 
    {
        health -= dmg;
    } 


}