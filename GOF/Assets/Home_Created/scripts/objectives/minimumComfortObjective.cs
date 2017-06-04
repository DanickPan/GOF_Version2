using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimumComfortObjective : MonoBehaviour {

	public int minimumValue;

	public ConfortController confortController;
	// Use this for initialization
	void Start () {
		
	}
	
	public bool check()
	{
		if (confortController.getValue () < minimumValue) 
		{
			return false;
		}
		return true;
	}
}
