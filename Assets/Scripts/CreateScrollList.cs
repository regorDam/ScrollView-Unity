using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item {
	public string name;
	public string wave;
	public string score;

}
public class CreateScrollList : MonoBehaviour {
	public GameObject sampleRow;
	public List<Item> itemList;

	public Transform contentPanel;

	void Start () {
		PopulateList ();
	}


	void PopulateList(){
		foreach (var item in itemList) {
			GameObject newRow = Instantiate(sampleRow) as GameObject;
			SampleRow row = newRow.GetComponent<SampleRow>();
			row.nameLabel.text = item.name;
			row.waveLabel.text = item.wave;
			row.scoreLabel.text = item.score;
			newRow.transform.SetParent(contentPanel);
		}
	}
}
