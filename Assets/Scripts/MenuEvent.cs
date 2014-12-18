using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuEvent : MonoBehaviour {
	public GameObject menuObject;
	public Animator menuAnim;

	// Use this for initialization
	void Start () {
		menuAnim = menuObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void MenuOpen(){
		menuAnim.SetBool("MenuClose",false);
		menuAnim.SetBool("MenuOpen",true);
	}

	public void MenuClose(){
		menuAnim.SetBool("MenuOpen",false);
		menuAnim.SetBool("MenuClose",true);
	}
}
