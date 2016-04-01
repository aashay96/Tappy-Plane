using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	
	public Vector2 jumpForce = new Vector2(0, 300);
	// Update is called once per frame

	
	void Update () {
		if (Input.GetKeyUp("space")|| Input.GetMouseButtonDown(0))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
		
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Application.LoadLevel(2);
		}
	}
	
	
	// Die by collision
	
	void OnCollisionEnter2D(Collision2D coll) {
		// Restart
		Application.LoadLevel(2);

	}

	}
		

