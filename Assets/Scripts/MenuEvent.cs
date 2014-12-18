using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuEvent : MonoBehaviour {
	public GameObject menuObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MenuOpen(){
        menuObject.SetActive(true);
	}

	public void MenuClose(){
        menuObject.SetActive(false);
	}
}
