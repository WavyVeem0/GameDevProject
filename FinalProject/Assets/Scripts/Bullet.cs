using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float distance;
    public int damage;
    public float lifeTime;

    public LayerMask targetLayer;

    private Vector2 _direction;

    private void Start() 
    {
    	_direction = GunTracker.direction;
    	print(_direction);
    }
    
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.up,distance,targetLayer);
        if(hit.collider != null)
        {
        	if(hit.collider.CompareTag("Enemy"))
        	{
        		hit.collider.GetComponent<Enemy>().TakeDamage(damage);
        	}
        	Destroy(gameObject);
        }

        if(lifeTime <= 0) 
        {
        	Destroy(gameObject);
        }

        lifeTime -= Time.deltaTime;
        transform.Translate(_direction*speed*Time.deltaTime);
    }
}
