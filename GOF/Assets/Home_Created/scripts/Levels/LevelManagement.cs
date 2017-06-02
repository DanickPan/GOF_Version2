using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagement : MonoBehaviour {

	private int levelChoice;
	public LevelObjective[] levelObjectives;

	// Use this for initialization
	void Start () 
	{
		levelChoice = 1;
		levelObjectives [1].display();
	}

	public void next()
	{
		if (levelChoice < levelObjectives.Length) 
		{
			levelChoice++;
		}

		levelObjectives [levelChoice].display ();
	}

	public void previous()
	{
		if (levelChoice > 0) 
		{
			levelChoice--;
		}

		levelObjectives [levelChoice].display ();
	}
	

}
