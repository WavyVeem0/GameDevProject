using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
	public Transform ShotPoint;
	public GameObject Bullet;
	public float FireRate = 5f;

	private float _timeCheck;

    private void Update()
    {
    	if(_timeCheck <= 0) 
    	{
    		if(Input.GetMouseButton(0))
        	{
        		Instantiate(Bullet,ShotPoint.position,transform.rotation);
        		_timeCheck = FireRate;
        	}
    	}
    	else 
    	{
    		_timeCheck -= Time.deltaTime;
    	}
        
    }
}
