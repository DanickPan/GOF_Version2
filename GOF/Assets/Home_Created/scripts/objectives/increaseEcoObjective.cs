using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseEcoObjective : MonoBehaviour {

	public int incrementValue;
	public EcoController ecoController;

	private int startValue;

	// Use this for initialization
	void Start () 
	{
		startValue = ecoController.getValue ();
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
