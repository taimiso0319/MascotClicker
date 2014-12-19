using UnityEngine;
using System.Collections;

public class PurchaceEvent : MonoBehaviour {

	public CountManager cManager;
    private ClickEvent clEvent;

	void Start(){
		cManager = GetComponent<CountManager>();
        clEvent = GetComponent<ClickEvent>();
	}
    public void Puchace(int buttonNum) {
        cManager.sum -= cManager.perSecNeedMoney[buttonNum];
		cManager.perSecCount[buttonNum]++;
        if(!cManager.isPurchaced[buttonNum]) {
            cManager.isPurchaced[buttonNum] = true;
        }
        cManager.NeedMoneySum(buttonNum);
	}
    
    //clEvent.AddDropList(buttonNum);
}
