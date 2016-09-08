using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	
	public float speedX = 0.1f;
	public float gravity = 0.06f;

	// Player reference from GameManager script.
	private Player player;

	// Desktop keybinds.
	private KeyCode[] jumpKey = { KeyCode.Space, KeyCode.UpArrow };
	private KeyCode[] crouchKey = { KeyCode.DownArrow };

	// Smartphone swipe binds.
	private Vector2 jumpSwipe = new Vector2(0, 10);

	// Use this for initialization
	void Start () {
		player = GameManager.Instance.player;
	}
	
	// Update is called once per frame
	void Update () {
		//if (SystemInfo.deviceType == DeviceType.Desktop) {
		//	Debug.Log ("Im running on a desktop");
		//} else {
			// Get the last touch.
		//if (Input.touches.Length > 0) {
		//	Touch lastTouch = Input.GetTouch (0);
		//	float moveHorizontal = lastTouch.deltaPosition.x;
		//	float moveVertical = lastTouch.deltaPosition.y;
		//	
		//	
		//	print (moveHorizontal + ", " + moveVertical);
		//
		//
		//	Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
		//
		//	//GameManager.Instance.player.gameObject.GetComponent<Rigidbody> ().AddForce (movement);
		//	
		//	if (moveVertical > 10) {
		//		GameManager.Instance.player.Jump ();
		//	}
		//}
		//}


		if (SystemInfo.deviceType == DeviceType.Desktop) {
			// Desktop.

			// Jump.
			foreach (KeyCode keycode in this.jumpKey) {
				if (Input.GetKeyDown (keycode)) {
					player.Jump ();
				}
			}

			// Crouch.
			foreach (KeyCode keycode in this.crouchKey) {
				if (Input.GetKeyDown (keycode)) {
					player.Crouch ();
				}
			}
			

			// Mouse shake.
		} else {
			// Smartphone.
			if (Input.touches.Length > 0) {
				// Get touch info.
				Touch lastTouch = Input.GetTouch (0);
				Vector2 touchVector = new Vector2 (lastTouch.deltaPosition.x, lastTouch.deltaPosition.y);

				// Jump.
//				if (touchVector.y > 10)
//				{
//					player.Jump ();
//				}
				if (touchVector.x >= this.jumpSwipe.x &&
				    touchVector.y > this.jumpSwipe.y)
				{
					player.Jump ();
				}

				// Crouch.


				// Phone shake.
			}
		}
	}

	void FixedUpdate() {
		// Add forward movement to player.
		//GameManager.Instance.player.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3(this.speedX, 0, 0));

		// Calculate y vector of player.
		float yVector = player.velocity.y - this.gravity;

		print ("Y velocity of player:" + player.velocity.y);

		// Apply y vector of player.
		GameManager.Instance.player.gameObject.GetComponent<CharacterController>().Move(new Vector3(this.speedX, yVector, 0));

		// Apply forward speed.
		this.speedX += 0.00001f;

		// Apply gravity to velocity.
		if (player.velocity.y > 0) {
			player.velocity.y -= this.gravity;
		}
	}
}
