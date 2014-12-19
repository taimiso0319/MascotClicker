using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuEvent : MonoBehaviour {
	public GameObject menuObject;
    public GameObject menuObjectPage2;

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

    public void MenuPageChange() {
        if(menuObject.activeSelf) {
            menuObject.SetActive(false);
            menuObjectPage2.SetActive(true);
        }else if(!menuObject.activeSelf) {
            menuObjectPage2.SetActive(false);
            menuObject.SetActive(true);
        } else if(menuObject.activeSelf && menuObjectPage2.activeSelf) {
            menuObject.SetActive(false);
            menuObjectPage2.SetActive(false);
        }
    }
}
