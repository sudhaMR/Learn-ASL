using UnityEngine;
using System.Collections;

public class whattimeAction : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	public void whattimeAnimate () {
		Debug.Log ("In what time");
		anim = gameObject.GetComponentInChildren<Animator> ();
		anim.SetInteger ("AnimPar", 1);
	}
}
