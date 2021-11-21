using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReloadBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public Gradient gradient;
    public Canvas canv;

    private void Awake() 
    {
    	canv.GetComponent<Canvas>().enabled = false;
    }

    public void Enable() 
    {
    	canv.GetComponent<Canvas>().enabled = true;
    }
    public void Disable() 
    {
    	canv.GetComponent<Canvas>().enabled = false;
    }

    public void SetReloadProgress(float procent) 
    {
    	slider.value = procent;
    	fill.color = gradient.Evaluate(slider.normalizedValue);
    }


}


