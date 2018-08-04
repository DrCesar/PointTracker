using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject totalField;
	public GameObject PointsField;

	private List<GameObject> pfList = new List<GameObject> ();
	private int pointsCount = 0;
	private int total;

    public Player()
    {
        
    }
	// Use this for initialization
	void Start () {
		total = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddPointsField()
    {
		GameObject pointsField = Instantiate (PointsField);
		pointsField.transform.parent = transform;
		pfList.Add (pointsField);
		totalField.transform.SetAsLastSibling ();
    }

	public void SetPointsField(int x) {
		pfList.Clear ();

		for (int i = 0; i < pointsCount; i++) {
			GameObject points = Instantiate (PointsField);
			points.transform.parent = this.transform;
		}
	}


    public void removePointsField(int index)
    {
		if (pfList.Count > 0) {
			Destroy (pfList [pfList.Count - 1]);
		}
    }

    public int getTotal()
    {
        return this.total;
    }

    public void calculateTotal()
    {
        this.total = 0;

		foreach (RectTransform child in transform) {
			if (child.tag == "PointsField") {
				this.total = this.total + int.Parse(child.GetComponent<InputField>().text);
				print (this.total);
			}
		}

		totalField.GetComponent<InputField>().text = this.total.ToString();
    }
}
