using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimumEcoObjective : MonoBehaviour {

	public int minimumValue;

	public EcoController ecoController;

	// Use this for initialization
	void Start () {

	}

	public bool check()
	{
		if (ecoController.getValue () < minimumValue) 
		{
			return false;
		}
		return true;
	}
}
