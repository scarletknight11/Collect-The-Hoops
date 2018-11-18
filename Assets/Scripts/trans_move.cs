using UnityEngine;
using System.Collections;

public class trans_move : MonoBehaviour {

	public float playerSpeed = 10.0f;

	public bool facingRight;
	public float move;
	 



	 
	// Use this for initialization
	void Start () 
	{
		move = Input.GetAxis("Horizontal");
		 

	}
	
	// Update is called once per frame
	void Update ()
	{
	

		if (move > 0 && !facingRight) 
		{
			Flip ();
		}

		else if (move < 0 && facingRight) 
		{
			Flip ();
		}
	
		if (Input.GetKey ("up")) 
		{
			// The "if" statement tells Unity that the instructions below will only excecute if the condition inside the parentheses is met.
			//Therefore the statement below will only execute if the "d" key is pressed.
			// "Input" is always used to tell Unity when an input is used.
			// "GetKey" defines the type or category of input that is called.
 		// ("d") defines the specific input that is used.
			transform.Translate (Vector3.up * playerSpeed * Time.deltaTime);
			// "playerSpeed" is a variable that can be changed in the Inspector to adjust the player's movement during gameplay.
			// "Time.deltaTime" is the amount of time it took Unity to render the last frame. Including "Time.deltaTime" ensures that the transform will not evaluate faster than a frame can be rendered. 
		}

		if (Input.GetKey ("down"))
		{
			transform.Translate (Vector3.down * playerSpeed * Time.deltaTime);
		}

		if (Input.GetKey ("right"))
		{
			transform.Translate (Vector3.right * playerSpeed * Time.deltaTime);
		}

		if (Input.GetKey ("left")) 
		{
			transform.Translate (Vector3.left * playerSpeed * Time.deltaTime);
		}


	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 botScale = transform.localScale;
		botScale *= -1;
		transform.localScale = botScale;
	}
}


