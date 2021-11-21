using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShoot : MonoBehaviour
{
	public Transform ShotPoint;
	public GameObject Bullet;
    public Text BulletCounter;
    public ReloadBar Bar;

	public float FireRate = 5f;
    public int StartMag = 30;
    public int Mag = 30;
    public float ReloadTime = 1f;


    private float _reloadCounter = 1f; 
    private bool _isReload = false;
	private float _timeCheck;

    private void Update()
    {
    	if(_timeCheck <= 0) 
    	{
    		if(Input.GetMouseButton(0) && Mag > 0 && !_isReload)
        	{
        		Instantiate(Bullet,ShotPoint.position,transform.rotation);
                Mag -= 1;
        		_timeCheck = FireRate;
        	}
    	}
    	else 
    	{
    		_timeCheck -= Time.deltaTime;
    	}


        if(Input.GetKeyDown(KeyCode.R)) 
        {
            _isReload = true;
            Bar.Enable();
        }

        if(_isReload && _reloadCounter > 0) 
        {
            _reloadCounter -= Time.deltaTime;
            Bar.SetReloadProgress(_reloadCounter);
        }
        else if(_isReload && _reloadCounter <= 0)
        {
            Mag = StartMag;
            _reloadCounter = ReloadTime; 
            _isReload = false;
            Bar.Disable();
        }

        BulletCounter.text = Mag.ToString();
        
    }
}
