using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	#region Variables
	/// <summary>
	/// The player.
	/// </summary>
	public GameObject player;
	#endregion

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Get the camera and player position.
		Vector3 cameraPos = transform.position;
		Vector3 playerPos = player.transform.position;

		// Set the x of the camera to the x of the player.
		cameraPos.x = playerPos.x + 5.0f;
		cameraPos.y = playerPos.y + 4.0f;

		// Apply the position to the camera.
		transform.position = cameraPos;
	}
}
