using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class player : MonoBehaviour {

	public Animator anim;

	void Start () {
		anim = gameObject.GetComponentInChildren<Animator> ();
	}

	public void whattimeAnimate () {
		Debug.Log ("In what time");
        anim = gameObject.GetComponentInChildren<Animator> ();
		anim.SetInteger ("AnimPar", 1);
	}

    public void idleAnimate()
    {
        Debug.Log("In idle");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 2);
    }

    void Update () {
	
		if (Input.GetKey ("up")) {
			anim.SetInteger ("AnimPar", 1);
		} else if(Input.GetKey("down")){
			anim.SetInteger ("AnimPar", 0);
		}
	}

    public void numberOneAnimate()
    {
        Debug.Log("In 1");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 11);
    }

    public void numberTwoAnimate()
    {
        Debug.Log("In 2");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 12);
    }

    public void numberThreeAnimate()
    {
        Debug.Log("In 3");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 13);
    }

    public void numberFourAnimate()
    {
        Debug.Log("In 4");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 14);
    }

    public void numberFiveAnimate()
    {
        Debug.Log("In 5");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 15);
    }

    public void numberSixAnimate()
    {
        Debug.Log("In 6");
        Animator anim;
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 16);
    }

    public void numberSevenAnimate()
    {
        Debug.Log("In 7");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 17);
    }

    public void numberEightAnimate()
    {
        Debug.Log("In 8");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 18);
    }


    public void numberNineAnimate()
    {
        Debug.Log("In 9");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 19);
    }

    public void numberTenAnimate()
    {
        Debug.Log("In 10");
        anim = gameObject.GetComponentInChildren<Animator>();
        anim.SetInteger("AnimPar", 110);
    }
}
