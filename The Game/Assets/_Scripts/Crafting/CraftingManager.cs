using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingManager : MonoBehaviour {

	//this should be it's own class/object
	public ArrayList inventory = new ArrayList();

	public GameObject CopperOre;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void mineOre() {
		GameObject newOre = Instantiate<GameObject> (CopperOre);
		inventory.Add (newOre);
	}
}
