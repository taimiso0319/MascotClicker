using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasText : MonoBehaviour {

	public GameObject sumTextObject;
	private Text sumText;
	public GameObject aveTextObject;
	private Text aveText;
	public CountManager cManager;
	
	public GameObject[] buttonObject = new GameObject[3];
	public Button[] button = new Button[3];

	void Start(){
		cManager = GetComponent<CountManager>();
		if(sumTextObject!=null)sumText = sumTextObject.GetComponent<Text>();
		if(aveTextObject!=null)aveText = aveTextObject.GetComponent<Text>();
		for(int i = 0; i < button.Length; i++){
			button[i] = buttonObject[i].GetComponent<Button>();
		}
	}

	// Update is called once per frame
	void Update () {
		if(sumText == null) return;
		if(aveText == null) return;
		sumText.text = Mathf.FloorToInt(cManager.sum).ToString();
		aveText.text = cManager.aveNum.ToString("F2") + "/sec";
		if(cManager.sum < 10){
			button[0].interactable = false;
		}else button[0].interactable = true;
		if(cManager.sum < 100){
			button[1].interactable = false;
		}else button[1].interactable = true;
		if(cManager.sum < 1000){
			button[2].interactable = false;
		}else button[2].interactable = true;
	}
}
