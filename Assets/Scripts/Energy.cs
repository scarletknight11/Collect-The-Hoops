using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour {

	public float min = 0f;
	public float max = 8f;
	public Vector3 currentPos;
	public float currentYPos;

	// Use this for initialization
	void Start () 
	{

		currentYPos = 2f;

	}

	// Update is called once per frame
	void Update () 
	{
		currentPos = transform.position;
		transform.position = new Vector3(Mathf.Lerp(min, max,Time.time), currentYPos, 0);
	}

}
