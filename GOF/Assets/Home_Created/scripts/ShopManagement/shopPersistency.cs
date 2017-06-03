using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class shopPersistency : MonoBehaviour {

	public Toggle toggle;
	public Condition condition;
	void Start () 
	{
		toggle.onValueChanged.SetPersistentListenerState(0,UnityEventCallState.Off);
		toggle.isOn = condition.satisfied;
		toggle.onValueChanged.SetPersistentListenerState(0,UnityEventCallState.RuntimeOnly);
	}
}
