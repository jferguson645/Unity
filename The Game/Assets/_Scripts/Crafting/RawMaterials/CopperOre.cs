using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperOre : RawMaterial {

	// Use this for initialization
	void Start () {
		materialName = "Copper Ore";
		determineQualityName ();
		determineQualityValue (qualityName);

		Debug.Log (qualityName);
		Debug.Log (qualityValue);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
