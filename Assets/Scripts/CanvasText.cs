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
	private Button[] button = new Button[3];

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
		sumText.text = Mathf.FloorToInt(cManager.sum).ToString() + "mp";
		aveText.text = cManager.aveNum.ToString("F2") + "mp/sec";
        for(int i = 0;i < button.Length;i++) ButtonInteractChange(i);
	}

    void ButtonInteractChange(int buttonNum) {
        if(cManager.sum < cManager.perSecNeedMoney[buttonNum]) {
            button[buttonNum].interactable = false;
        } else button[buttonNum].interactable = true;
    }

    
}
