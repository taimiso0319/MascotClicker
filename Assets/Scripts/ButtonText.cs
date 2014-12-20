using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonText : MonoBehaviour {

    public GameObject[] buttonNeedMoneyTextObject = new GameObject[3];
    public Text[] buttonNeedMoneyText = new Text[3];
    CountManager cManager;

	// Use this for initialization
	void Start () {
        cManager = GetComponent<CountManager>();
        for(int i = 0;i < buttonNeedMoneyTextObject.Length;i++)
            buttonNeedMoneyText[i] = buttonNeedMoneyTextObject[i].GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        for(int i = 0;i < buttonNeedMoneyText.Length;i++) {
            buttonNeedMoneyText[i].text = cManager.perSecNeedMoney[i].ToString() + "mp";
        }
	}
}
