using UnityEngine;
using UnityEngine.UI; // grants access to Unity's UI library of terms and functions.
using System.Collections;

public class HealthUI : MonoBehaviour 
{

	public Image hBar; // creates a variable to hold the Image object's information.

	public PlaneHealth pHealth;  // creates a variable to hold the "currentHp" variable inside of the "CycleHealth" script attached to the Player object.

	// Use this for initialization
	void Start () 
	{
		hBar = GetComponent<Image> ();  // assigns the the Image object to the "hBar" variable.

		pHealth = GameObject.Find ("plane_1").GetComponent<PlaneHealth> ();  //looks for the "CycleHealth script and assigns it to the "cHealth" variable.

	}

	// Update is called once per frame
	void Update () 
	{
		hBar.fillAmount = pHealth.currHp;  // links the Player's health ("currHp") to the slider for the Health bar (hBar)
	}
}
