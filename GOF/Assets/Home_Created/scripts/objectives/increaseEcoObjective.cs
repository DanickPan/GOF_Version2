using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseEcoObjective : MonoBehaviour {

	public int incrementValue;
	public EcoController ecoController;

	private int startValue;

	// Use this for initialization
	void Start () 
	{
		startValue = (int)ecoController.getValue ();
	}

	public bool check()
	{
		if (ecoController.getValue () - startValue < incrementValue) 
		{
			return false;
		}
		return true;
	}
}
