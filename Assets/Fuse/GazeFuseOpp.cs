using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GazeFuseOpp : MonoBehaviour 
{
	public GameObject gazeGameObject;
	private Image image;

	void Start() 
	{
		image = GetComponent<Image>();
	}

	void Update() 
	{
		if (gazeGameObject == null || GazeInputModuleFuse.gazeGameObject == gazeGameObject) 
		{
			//if (EndManager.Instance.firstVideoEnded) {
				FuseAmountChanged(GazeInputModuleFuse.gazeFraction);
			//}

		}
	}

	void FuseAmountChanged(float fuseAmount)
	{
		if (image != null)
		{
			image.fillAmount = -fuseAmount;
		}
	}
}