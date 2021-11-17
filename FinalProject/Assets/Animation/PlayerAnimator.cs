using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
  	private Animator _anim;

  	private void Awake() {
  		_anim = GetComponent<Animator>();
  	}
    

    private void Update()
    {
        if(Input.GetKey(KeyCode.A)
        	|| Input.GetKey(KeyCode.D)
        	|| Input.GetKey(KeyCode.S)
        	|| Input.GetKey(KeyCode.W))
        {
        	_anim.SetBool("isRun",true);
        }
        else _anim.SetBool("isRun",false);
    }
}
