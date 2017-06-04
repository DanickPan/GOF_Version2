using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMoneyObjective : MonoBehaviour {

	public int incrementValue;
	public MoneyController moneyController;

	private int startValue;

	// Use this for initialization
	void Start () 
	{
		startValue = (int)moneyController.getValue ();
	}

	public bool check()
	{
		if (moneyController.getValue () - startValue < incrementValue) 
		{
			return false;
		}
		return true;
	}
}
