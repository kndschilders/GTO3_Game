using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	#region Variables
	/// <summary>
	/// The instance.
	/// </summary>
	public static GameManager Instance;

	/// <summary>
	/// The player.
	/// </summary>
	public Player player;

	/// <summary>
	/// The lowest Y position.
	/// </summary>
	public float lowestYPosition;
	#endregion

	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake() {
		Instance = this;
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
		
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {
		// Reset the game when the player's y position is lower than the given y location.
		if (this.player.transform.position.y < this.lowestYPosition) {
			this.Reset ();
		}
	}

	/// <summary>
	/// Reset the whole game.
	/// </summary>
	void Reset() {
		this.player.transform.position = new Vector3 (1.0f, 3.0f, 0.0f);
	}
}
