using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlaneHealth : MonoBehaviour 
{

	public float startHp;    // creates a variable that holds the amount of health the Player starts the game with.
	public float currHp;    // creates a variable that holds the health amount of the Player at a given time during gameplay.

	public float dropHurt = 0.2f;  // creates a variable that will hold the amount of damage caused by a collision with a Dropbot.



	// Use this for initialization
	void Start () 
	{
		startHp = 1f;  //the amount of health the Player starts the game with.
		currHp = startHp;  //sets the current Health amount equal to the "startupHp" value
	}


	// Update is called once per frame
	void Update () 
	{

	}

	void OnCollisionEnter2D (Collision2D other)
		{
		//if (other.gameObject.tag == "Drop")  // if the Player collides with a Dropbot.
		//{
		//	print ("Ouch!");
		//	currHp -= dropHurt;  // the Player's health will be reduced by the amnount of 'dropHurt".
		//	Destroy (other.gameObject);  // the Dropbot object will be destroyed.
		}
	}

