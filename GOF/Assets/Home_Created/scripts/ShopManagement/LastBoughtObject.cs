using UnityEngine.UI;
using UnityEngine;

public class LastBoughtObject : MonoBehaviour 
{
	private Toggle lastActivated;

	void Start()
	{
		lastActivated = null;
	}

	public Toggle getLastBoughtObject()
	{
		return lastActivated;
	}

	public void newObjectBought(Toggle toggle)
	{
		lastActivated = toggle;
	}

}
