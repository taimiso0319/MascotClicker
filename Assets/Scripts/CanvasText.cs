using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CanvasText : MonoBehaviour {

	public GameObject sumTextObject;
	private Text sumText;
	public GameObject aveTextObject;
	private Text aveText;
	public CountManager cManager;
	
	public GameObject[] characterButtonObject;
	private Button[] characterButton;
	public GameObject[] clickButtonObject;
	private Button[] clickButton;
	private Text[] clickText;
	private Text[] charText;
	private Text[] charPerSecText;

	
	void Start(){
		cManager = GetComponent<CountManager>();
		characterButtonObject = new GameObject[cManager.characterObject.Length];
		clickButtonObject = new GameObject[cManager.clickObject.Length];
		charText = new Text[cManager.characterObject.Length];
		charPerSecText = new Text[cManager.characterObject.Length];
		clickText = new Text[cManager.clickObject.Length];
		characterButton = new Button[characterButtonObject.Length];
		clickButton = new Button[clickButtonObject.Length];
		if(sumTextObject!=null)sumText = sumTextObject.GetComponent<Text>();
		if(aveTextObject!=null)aveText = aveTextObject.GetComponent<Text>();
		for(int i = 0; i < cManager.characterObject.Length; i++){
			characterButtonObject[i] = cManager.characterObject[i];
			characterButton[i] = characterButtonObject[i].GetComponent<Button>();
			charText[i] = characterButtonObject[i].transform.FindChild("NeedMoney").GetComponent<Text>();
			charPerSecText[i] = characterButtonObject[i].transform.FindChild("PerSec").GetComponent<Text>();
			charPerSecText[i].text = "+" + (cManager.perSecVal[i]*50).ToString() + "mp";
		}
		for(int i = 0; i < cManager.clickObject.Length;i++){
			clickButtonObject[i] = cManager.clickObject[i];
			clickButton[i] = clickButtonObject[i].GetComponent<Button>();
			clickText[i] = clickButtonObject[i].transform.FindChild("Text").GetComponent<Text>();
			clickText[i].text = cManager.clickNeedMoney[i].ToString() + "mp";
		}

	}

	// Update is called once per frame
	void Update () {
		if(sumText == null) return;
		if(aveText == null) return;
		sumText.text = cManager.sum.ToString("F0") + "mp";
		aveText.text = cManager.aveNum.ToString("F0") + "mp/sec";
        for(int i = 0;i < characterButton.Length;i++){
			ButtonInteractChange(i);
			SetNeedMoneyText(i);
		}
		for(int i = 0; i< clickButtonObject.Length; i++) ClickButtonPurchace(i);
	}

    void ButtonInteractChange(int buttonNum) {
        if(cManager.sum < cManager.perSecNeedMoney[buttonNum]) {
            characterButton[buttonNum].interactable = false;
        } else characterButton[buttonNum].interactable = true;
    }
	void ClickButtonPurchace(int buttonNum){
		if(cManager.sum < cManager.clickNeedMoney[buttonNum]){
			clickButton[buttonNum].interactable = false;
		}else clickButton[buttonNum].interactable = true;
		if(cManager.isClickPurchaced[buttonNum]){
			clickButton[buttonNum].interactable = false;
			clickText[buttonNum].text = "Purchaced!!";
		}
	}
	void SetNeedMoneyText(int arrayNum){
		charText[arrayNum].text = cManager.perSecNeedMoney[arrayNum].ToString() + "mp";
	}
	
	
}
