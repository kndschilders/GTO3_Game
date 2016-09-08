using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManager
{
	#region Variables
	/// <summary>
	/// The coins.
	/// </summary>
	public Resource coins;
	#endregion

	/// <summary>
	/// Initializes a new instance of the <see cref="ResourceManager"/> class.
	/// </summary>
	public ResourceManager ()
	{
		this.coins = new Coin (0.0);
	}
}
