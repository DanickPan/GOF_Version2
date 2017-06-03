using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Reflection;

public class BuyObjectReaction : Reaction 
{
	public LastBoughtObject lastObject;
	public int objectPrize;
	public Toggle toggle;
	public shopConditionsManager shopConditionsManager;
	public Condition linkedCondition;

	private MoneyController moneyController;

	protected override void SpecificInit ()
	{
		moneyController = FindObjectOfType<MoneyController> ();
	}

	protected override void ImmediateReaction ()
	{

		if (toggle.isOn) 
		{
			if (moneyController.buyShopObject (objectPrize)) 
			{				
				shopConditionsManager.onPurchase (linkedCondition);
				lastObject.newObjectBought (toggle);
			} else 
			{
				toggle.onValueChanged.SetPersistentListenerState(0,UnityEventCallState.Off);
				toggle.isOn = false;
				toggle.onValueChanged.SetPersistentListenerState(0,UnityEventCallState.RuntimeOnly);

				if (lastObject.getLastBoughtObject () != null) 
				{
					lastObject.getLastBoughtObject().onValueChanged.SetPersistentListenerState(0,UnityEventCallState.Off);
					lastObject.getLastBoughtObject().isOn = true;
					lastObject.getLastBoughtObject().onValueChanged.SetPersistentListenerState(0,UnityEventCallState.RuntimeOnly);
				}

			}
		}

	}


}
