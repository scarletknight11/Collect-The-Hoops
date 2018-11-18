using UnityEngine;
using System.Collections;

public class ai : MonoBehaviour 
{

	public Vector3 leftPoint;
	public Vector3 rightPoint;
	public float botSpeed = 0.5f;
	public bool aiSwitch = false;
	public Renderer rend;
	public GameObject Bullet;

	// Use this for initialization
	void Start () 
	{ 
		leftPoint = GameObject.Find ("left").transform.position;
		rightPoint = GameObject.Find ("right").transform.position;	
		aiSwitch = true;	
		rend = GetComponent<Renderer>();
		rend.enabled = true;
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

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.gameObject.tag);

		if (other.gameObject.tag == "Bullet") {
			Debug.Log ("Collision detected");
			Destroy (this.gameObject);		

		}
	}

}
