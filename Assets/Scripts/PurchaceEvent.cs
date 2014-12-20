using UnityEngine;
using System.Collections;

public class PurchaceEvent : MonoBehaviour {

	public CountManager cManager;
    private ClickEvent clEvent;

	void Start(){
		cManager = GetComponent<CountManager>();
        clEvent = GetComponent<ClickEvent>();
	}
    public void CharacterPuchace(int buttonNum) {
        cManager.sum -= cManager.perSecNeedMoney[buttonNum];
		cManager.perSecCount[buttonNum]++;
		if(!cManager.isCharacterPurchaced[buttonNum]) {
			cManager.isCharacterPurchaced[buttonNum] = true;
        }
        cManager.NeedMoneySum(buttonNum);
	}
	public void ClickPurchace(int buttonNum){
		clEvent.AddDropList(buttonNum);
		cManager.sum -= cManager.clickNeedMoney[buttonNum];
		cManager.isClickPurchaced[buttonNum] = true;
		cManager.perClick = cManager.perClickMoney[buttonNum];
	}
    
    //clEvent.AddDropList(buttonNum);
}
