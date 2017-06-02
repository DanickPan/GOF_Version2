using UnityEngine;
using UnityEngine.UI;

public class LevelObjective : MonoBehaviour {

	public Objective[] objectives;
	public Text levelObjectivesText;

	public void display()
	{
		string textToDisplay = "Level objectives : \n\n";

		for (int i = 0; i < objectives.Length; i++) 
		{
			textToDisplay += objectives [i].text;
			textToDisplay += " : ";
			if (objectives [i].isAchieved) {
				textToDisplay += "OK \n";
			} else {
				textToDisplay += "not OK \n";
			}
		}

		levelObjectivesText.text = textToDisplay;
	}

}
