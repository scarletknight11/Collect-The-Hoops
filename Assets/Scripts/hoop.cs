using UnityEngine;
using System.Collections;

public class hoop : MonoBehaviour {

	public Renderer rend;
	public GameObject player;
	 

	// Use this for initialization
	void Start () 
	{

		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.gameObject.tag);

		if (other.gameObject.tag == "Player") {
			Debug.Log ("Collision detected");
			Destroy (this.gameObject);		

		}




	}

}
