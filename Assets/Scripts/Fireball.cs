using UnityEngine;
using System.Collections;

public class Fireball: MonoBehaviour 
{
	public float blastSpeed = 400f;
	public Transform spawnPt;
	public Rigidbody2D clone;
	public Rigidbody2D projectile;

	 

	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		//if (Input.GetKey("w"))
		//{
		//	Blaster ();
		//}  
		if (Input.GetMouseButtonDown (0))
		{
			Blaster ();
		}
		 
	}

	void Blaster ()
	{
		clone = Instantiate (projectile, spawnPt.position, spawnPt.rotation) as Rigidbody2D;
		clone.AddForce (Vector3.right * blastSpeed);

	}


}