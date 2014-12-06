using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public float bulletSpeed = 5.0f;

	public void Fire(int direction) {
		// Direction: 0 = up, 1 = right, 2 = down, 3 = left
		float xvel = 0.0f;
		float yvel = 0.0f;
		if (direction == 0) {
			yvel = -bulletSpeed;
		} else if (direction == 1) {
			xvel = bulletSpeed;
		} else if (direction == 2) {
			yvel = bulletSpeed;
		} else {
			xvel = -bulletSpeed;
		}
		this.rigidbody2D.velocity = new Vector2(xvel, yvel);
	}
}
