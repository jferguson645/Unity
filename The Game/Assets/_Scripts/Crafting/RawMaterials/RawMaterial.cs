using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RawMaterial : MonoBehaviour {

	protected string qualityName = null;
	protected float qualityValue = 0f;
	protected string materialName = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected void determineQualityName() {
		ArrayList qualityDistribution = new ArrayList();
		for (int i = 0; i <= 2; i++) {
			qualityDistribution.Add ("Poor");
		}
		for (int i = 0; i <= 5; i++) {
			qualityDistribution.Add ("Mediocre");
		}
		for (int i = 0; i <= 6; i++) {
			qualityDistribution.Add ("Standard");
		}
		for (int i = 0; i <= 4; i++) {
			qualityDistribution.Add ("Great");
		}
		for (int i = 0; i <= 2; i++) {
			qualityDistribution.Add ("Exceptional");
		}
		qualityDistribution.Add ("Legendary");

		int num = Random.Range (0, qualityDistribution.Count);
		qualityName = qualityDistribution[num].ToString();
	}

	protected void determineQualityValue(string qualityName) {
		//each quality name has a numeric range it can be. Determine the quality value based on the quality name.
		List<float> poorDistribution = new List<float>{};
		List<float> mediocreDistribution = new List<float>{};
		List<float> standardDistribution = new List<float>{};
		List<float> greatDistribution = new List<float>{};
		List<float> exceptionalDistribution = new List<float>{};
		List<float> legendaryDistribution = new List<float>{};
		int num;

		poorDistribution.Add (0.1f);
		poorDistribution.Add (0.15f);
		poorDistribution.Add (0.2f);
		poorDistribution.Add (0.25f);

		mediocreDistribution.Add (0.3f);
		mediocreDistribution.Add (0.35f);
		mediocreDistribution.Add (0.4f);
		mediocreDistribution.Add (0.45f);
		mediocreDistribution.Add (0.5f);

		standardDistribution.Add (0.55f);
		standardDistribution.Add (0.6f);
		standardDistribution.Add (0.65f);
		standardDistribution.Add (0.7f);
		standardDistribution.Add (0.75f);

		greatDistribution.Add (0.8f);
		greatDistribution.Add (0.85f);
		greatDistribution.Add (0.9f);
		greatDistribution.Add (0.95f);
		greatDistribution.Add (1f);

		exceptionalDistribution.Add (1.05f);
		exceptionalDistribution.Add (1.1f);
		exceptionalDistribution.Add (1.15f);
		exceptionalDistribution.Add (1.2f);
		exceptionalDistribution.Add (1.25f);

		legendaryDistribution.Add (1.3f);
		legendaryDistribution.Add (1.35f);
		legendaryDistribution.Add (1.4f);
		legendaryDistribution.Add (1.45f);
		legendaryDistribution.Add (1.5f);

		switch (qualityName) {
			case "Poor":
				num = Random.Range (0, poorDistribution.Count);
			qualityValue = poorDistribution[num];
				break;
			case "Mediocre":
				num = Random.Range (0, mediocreDistribution.Count);
			qualityValue = mediocreDistribution[num];
				break;
			case "Standard":
				num = Random.Range (0, standardDistribution.Count);
			qualityValue = standardDistribution[num];
				break;
			case "Great":
				num = Random.Range (0, greatDistribution.Count);
			qualityValue = greatDistribution[num];
				break;
			case "Exceptional":
				num = Random.Range (0, exceptionalDistribution.Count);
			qualityValue = exceptionalDistribution[num];
				break;
			case "Legendary":
				num = Random.Range (0, legendaryDistribution.Count);
			qualityValue = legendaryDistribution[num];
				break;
		}


	}
}
