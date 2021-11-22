using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public Gradient gradient;

    public void Awake() 
    {
    	SetHealth(DataHolder.playerLastHp);
    }
    public void SetHealth(int hp) 
    {
    	slider.value = hp;
    	fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
