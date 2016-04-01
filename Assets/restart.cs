using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {

	// Use this for initialization
	public void ChangetoScene(int c) {
		Application.LoadLevel (c);
	}
}
