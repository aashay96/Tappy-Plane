using UnityEngine;
using System.Collections;

public class pal : MonoBehaviour {

	// Use this for initialization
	public Vector2 jumpForce = new Vector2(0, 150);
	// Update is called once per frame
	
	
	void Update () {
		if (Input.GetKeyUp("space")|| Input.GetMouseButtonDown(0))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
}
}