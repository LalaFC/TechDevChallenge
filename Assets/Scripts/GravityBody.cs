using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class GravityBody : MonoBehaviour {
	
<<<<<<< Updated upstream:Assets/Scripts/GravityBody.cs
	GravityAttractor planet;
=======
	public GravityAttractor planet;
>>>>>>> Stashed changes:Assets/Scripts/PlayerScrips/GravityBody.cs
	new Rigidbody rigidbody;
	
	void Awake () {
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
		rigidbody = GetComponent<Rigidbody> ();

		// Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
		rigidbody.useGravity = false;
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	void FixedUpdate () {
		// Allow this body to be influenced by planet's gravity
		planet.Attract(rigidbody);
	}
}