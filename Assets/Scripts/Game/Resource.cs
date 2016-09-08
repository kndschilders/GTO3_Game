using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public abstract class Resource
{
	#region Variables
	public double amount {
		get;
		protected set;
	}

	#endregion

	/// <summary>
	/// Initializes a new instance of the <see cref="Resource"/> class.
	/// </summary>
	public Resource (double initialAmount)
	{
		this.amount = initialAmount;
	}
}
