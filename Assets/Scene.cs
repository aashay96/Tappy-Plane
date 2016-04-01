using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	public void ChangetoScene(int c) {
		Application.LoadLevel (c);
	}
}
