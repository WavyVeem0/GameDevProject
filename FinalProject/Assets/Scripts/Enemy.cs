using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int damage = 5;
    public float fireRate = 1f;
    public Door door;
    public GameObject player;

    private Rigidbody2D _rb;
    private float _fireRateCounter;
    private void Awake() 
    {
        _fireRateCounter = fireRate;
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

        //attack
        if((currentPos-playerPos).magnitude < 1.5f && _fireRateCounter <= 0)
        {
            player.GetComponent<PlayerStats>().TakeDamage(damage);
            _fireRateCounter = fireRate;
        }
        _fireRateCounter -= Time.deltaTime;



    }

    public void TakeDamage(int dmg) 
    {
        health -= dmg;
    } 


}