using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]

public class idleAction : MonoBehaviour{
	Animator anim;
	public void Start(){
		Debug.Log ("In idle Start");
	}
	// Use this for initialization
	public void idleAnimate () {
		Debug.Log ("In idle");
		anim = gameObject.GetComponentInChildren<Animator> ();
		anim.SetInteger ("AnimPar", 0);
	}


	// Update is called once per frame

}
