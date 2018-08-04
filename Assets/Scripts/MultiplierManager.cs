using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierManager : MonoBehaviour {

	public GameObject MultiplierField;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddMultiplierField() {
		GameObject newField = Instantiate (MultiplierField);
		newField.transform.parent = this.transform;
	}
}
