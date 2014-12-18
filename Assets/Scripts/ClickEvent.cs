using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour {

	public CountManager cManager;

	// Use this for initialization
	void Start () {
		cManager = GetComponent<CountManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void ScreenClick(){
		cManager.sum += cManager.perClick;
		cManager.clickSum += cManager.perClick;
		cManager.clickedNum += cManager.perClick;
	}
}