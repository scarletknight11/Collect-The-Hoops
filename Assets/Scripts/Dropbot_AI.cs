using UnityEngine;
using System.Collections;

public class Dropbot_AI : MonoBehaviour 
{

	public Vector3 leftPoint;
	public Vector3 rightPoint;
	public float botSpeed = 0.5f;
	public bool aiSwitch = false;

	// Use this for initialization
	void Start () 
	{ 
		leftPoint = GameObject.Find ("left").transform.position;
		rightPoint = GameObject.Find ("right").transform.position;	
		aiSwitch = true;	
	}

	// Update is called once per frame
	void Update () 
	{

		Debug.DrawLine (leftPoint, rightPoint, Color.red, 10f);

		if (aiSwitch) 
		{
			transform.position = Vector3.Lerp (leftPoint, rightPoint, Mathf.PingPong (botSpeed * Time.time, 1f));
		}
	}


}
