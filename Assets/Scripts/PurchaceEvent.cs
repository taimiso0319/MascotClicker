using UnityEngine;
using System.Collections;

public class PurchaceEvent : MonoBehaviour {

	public CountManager cManager;

	void Start(){
		cManager = GetComponent<CountManager>();
	}
	public void Puchace1(){
		cManager.perSec1++;
		cManager.sum -= 10;
	}
	public void Puchace10(){
		cManager.perSec10++;
		cManager.sum -= 100;
	}
	public void Puchace100(){
		cManager.perSec100++;
		cManager.sum -= 1000;
	}
}
