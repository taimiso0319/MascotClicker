using UnityEngine;
using System.Collections;

public class CountManager : MonoBehaviour {
	public float sum = 0;
	public float clickSum = 0;
	public float perSec1 = 0;
	public float perSec10 = 0;
	public float perSec100 = 0;
	public float perClick = 1;
	public float clickedNum = 0;
	private float aveSum = 0;
	public float aveNum = 0;
	public float[] secNum = new float[50];
	private int roopNum = 0;

	void Awake(){
		for(int i = 0; i < secNum.Length; i++)secNum[i] = 0;
	}

	void FixedUpdate () {
		sum +=(0.002f * perSec1)
			+ (0.02f * perSec10)
			+ (0.2f * perSec100);
		secNum[roopNum] = (0.002f * perSec1)
			+ (0.02f * perSec10)
			+ (0.2f * perSec100)
			+ clickedNum;
		foreach(float i in secNum){
			aveSum += i;
		}
		aveNum = aveSum;
		aveSum = 0;
		roopNum++;
		clickedNum = 0;
		if(roopNum == 50)roopNum = 0;
	}
}
