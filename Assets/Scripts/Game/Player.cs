using UnityEngine;
using System;
using System.Collections;

public class Player : MonoBehaviour
{
	#region Variables
	/// <summary>
	/// Gets the resource manager.
	/// </summary>
	/// <value>The resource manager.</value>
	public ResourceManager resourceManager {
		get;
		private set;
	}

	/// <summary>
	/// Gets a value indicating whether this <see cref="Player"/> is grounded.
	/// </summary>
	/// <value><c>true</c> if is grounded; otherwise, <c>false</c>.</value>
	public bool isGrounded {
		get;
		private set;
	}

	/// <summary>
	/// Gets a value indicating whether this <see cref="Player"/> is crouching.
	/// </summary>
	/// <value><c>true</c> if is crouching; otherwise, <c>false</c>.</value>
	public bool isCrouching {
		get;
		private set;
	}

	/// <summary>
	/// The start position.
	/// </summary>
	Vector3 startPosition;

	/// <summary>
	/// The velocity of the player.
	/// </summary>
	public Vector2 velocity = new Vector2(0.0f, 0.0f);
	#endregion

	/// <summary>
	/// Initializes a new instance of the <see cref="Player"/> class.
	/// </summary>
	public Player ()
	{
		this.resourceManager = new ResourceManager ();
		this.isGrounded = true;
		this.isCrouching = false;
	}

	/// <summary>
	/// Jump this instance.
	/// </summary>
	public void Jump()
	{
		if (this.isGrounded) {
			//this.GetComponent<Rigidbody> ().AddForce (0, 500, 0);
			this.velocity.y = this.velocity.y + 100.0f;
			print ("JUMP!");
		}
	}

	/// <summary>
	/// Crouch this instance.
	/// </summary>
	public void Crouch() {
		if (this.isGrounded) {
			// Crouch.
		}
	}

	/// <summary>
	/// Raises the collision enter event.
	/// </summary>
	/// <param name="collision">Collision.</param>
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Floor") {
			this.isGrounded = true;
		}
	}

	/// <summary>
	/// Raises the collision exit event.
	/// </summary>
	/// <param name="collision">Collision.</param>
	void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.name == "Floor") {
			this.isGrounded = false;
		}
	}
}
