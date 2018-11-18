using UnityEngine;
using System.Collections;

public class DropBotTrigger : MonoBehaviour {


	public AI_Move triggerSwitch;

	//public float jumpSpeed = 10f;


	// Use this for initialization
	void Start () 
	{
		triggerSwitch = GameObject.Find ("boat1").GetComponent<AI_Move> ();

		//scanPt = GameObject.Find ("sqaure").transform;

	}

	// Update is called once per frame
	void Update () 
	{



		// && = and
		// || = or



	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			triggerSwitch.aiSwitch = false;

		}
	}
}
