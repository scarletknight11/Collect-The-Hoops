using UnityEngine;
using System.Collections;

public class EnemyGuns : MonoBehaviour {

	//public GameObject bulletfire;
	public float laserSpeed = 500.0f;
	public Rigidbody2D clone;
	public Rigidbody2D Bullet1;
	public Transform bulletfire;


	// Use this for initialization
	void Start () 
	{
	
		//fire an eney bullet after 1 second
		//Invoke ("FireEnemyBullet", 1f);
		bulletfire = GameObject.Find ("bulletfire").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
	

	}

	//function to fire an enemy bullet
	void FireEnemyBullet()
	{
		//get a reference to the player's ship
		GameObject playerShip = GameObject.Find("plane_1");


		clone = Instantiate (Bullet1, bulletfire.position, bulletfire.rotation) as Rigidbody2D;
		clone.AddForce(Vector2.right *laserSpeed *Time.deltaTime);
		//if (playerShip != null) 
		//{
		//instantiate an enemy bullet
		//GameObject bullet = (GameObject)Instantiate (bulletfire);

		//set the bullet's initial position
		//bullet.transform.position = transform.position;

		//compute the bullet's direction towards the player's ship
		//Vector2 direction = playerShip.transform.position - bullet.transform.position;

		//set the bullet's direction
//			bullet.GetComponent<EnemyBullet>().setDirection(direction);

		
		}
	}

