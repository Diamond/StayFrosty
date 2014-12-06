using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed = 5.0f;
	
	// Update is called once per frame
	void Update () {
		float x = (Input.GetAxis ("Horizontal") * speed) * Time.deltaTime;
		float y = (Input.GetAxis ("Vertical") * speed) * Time.deltaTime;
		this.transform.position += new Vector3(x, y, 0.0f);
	}
}
