using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracker : MonoBehaviour {

	public GameObject Player;


	private int pointsCount = 0;
	private List<GameObject> playerList;

	// Use this for initialization
	void Start () {
		playerList = new List<GameObject> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void addPlayer()
	{
		GameObject player = Instantiate (Player);
		player.transform.parent = this.transform;
		playerList.Add (player);
	}

	public void removePlayer(int index)
	{
		if (playerList.Count > 0)
			Destroy (playerList [playerList.Count - 1]);
	}

	public void addPointsField()
	{
		foreach (RectTransform child in transform) {
			if (child.tag == "Points") {
				child.gameObject.GetComponent<PointsManager> ().AddPointsText ();
			} else if (child.tag == "Multiplier") {
				child.gameObject.GetComponent<MultiplierManager> ().AddMultiplierField ();
			} else {
				child.gameObject.GetComponent<Player> ().AddPointsField ();
			}

		}

		this.pointsCount += 1;

	}

	public void removePointsField(int index)
	{

	}
}
