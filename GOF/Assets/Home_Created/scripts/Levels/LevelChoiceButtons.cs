using UnityEngine;
using UnityEngine.UI;

public class LevelChoiceButtons : MonoBehaviour {

	private LevelManagement levelManagement;

	void Start()
	{
		levelManagement = FindObjectOfType<LevelManagement> ();
	}

	public void btnNextClicked()
	{
		levelManagement.next ();
	}

	public void btnPreviousClicked()
	{
		levelManagement.previous ();
	}
}
