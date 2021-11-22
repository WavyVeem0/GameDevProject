using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MainBuildUI : MonoBehaviour
{
    public Canvas canv;
    public Text counter;

    public float oneHpRecovery = 10f;
    private float _recoveryCounter;

    private void Awake() 
    {
    	counter.text = DataHolder.playerLastHp.ToString();
    	_recoveryCounter = oneHpRecovery;
    }

    private void OnMouseEnter() 
    {
    	canv.enabled = true;
    }

    private void OnMouseExit() 
    {
    	canv.enabled = false;
    }

    private void Update() 
    {
    	if(Convert.ToInt32(counter.text) <= 100 && _recoveryCounter <= 0) 
    	{
    		_recoveryCounter = oneHpRecovery;
    		DataHolder.playerLastHp += 1;
    		counter.text = DataHolder.playerLastHp.ToString();

    	}
    	else
    	{
    		_recoveryCounter -= Time.deltaTime;
    	}
    }

    public void Upgrade() 
    {
    	if(DataHolder.totalMetal >= 10) 
    	{
    		DataHolder.totalMetal -= 10;
    		oneHpRecovery /= 2;
    	}
    }
}
