using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCanvasDisabler: MonoBehaviour {

	public GameObject statusCanvas;
	public GameObject objectivesCanvas;


	public void disableCanvas()
	{
		statusCanvas.SetActive (false);
		objectivesCanvas.SetActive (false);
	}

	public void enableCanvas()
	{
		statusCanvas.SetActive (true);
		objectivesCanvas.SetActive (true);
	}

	public bool isDisabled()
	{
		if (statusCanvas.activeSelf) {
			return true;
		} else {
			return false;
		}
	}
}
