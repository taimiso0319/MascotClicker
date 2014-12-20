using UnityEngine;
using System.Collections;

public class CountManager : MonoBehaviour {
	public int testNum = 0;
	public int sumTest;
	public float sum = 0;
	public int clickSum = 0;
    public GameObject parentObject;
	public GameObject[] perSecDropHeadObject = new GameObject[6];
	public GameObject[] characterObject = new GameObject[6];
	public GameObject[] clickObject = new GameObject[6];
	public float[] perSecCount;
    public float[] perSecVal = new float[6];
    public int[] perSecNeedMoneyDef = new int[6];
	public int[] perSecNeedMoney = new int[6];
	public int[] clickNeedMoney = new int[6];
	public int[] perClickMoney = new int[6];
	private bool[] getTime;
    private float[] timeCounter;
    private float[] dropTime;
	public float moneyUpTimes = 0.3f;
	public bool[] isCharacterPurchaced;
	public bool[] isClickPurchaced = new bool[6];
	public int perClick = 1;
	public float clickedNum = 0;
	private float aveSum = 0;
	public float aveNum = 0;
	public float[] secNum = new float[50];
	private int roopNum = 0;

	void Awake(){
		sum = testNum;
		perSecCount = new float[perSecDropHeadObject.Length];
        isCharacterPurchaced = new bool[perSecCount.Length];
        timeCounter = new float[perSecCount.Length];
        dropTime = new float[perSecCount.Length];
		getTime = new bool[perSecCount.Length];
		for(int i = 0;i < isClickPurchaced.Length;i++){
			isClickPurchaced[i] = false;
		}
		for(int i = 0;i < isCharacterPurchaced.Length;i++) {
			isCharacterPurchaced[i] = false;
            timeCounter[i] = 0;
            perSecNeedMoney[i] = perSecNeedMoneyDef[i];
        }
		for(int i = 0; i < secNum.Length; i++)secNum[i] = 0;
	}

	void FixedUpdate () {
        secNum[roopNum] = 0;
        for(int i = 0;i < perSecCount.Length;i++) {
            sum += perSecVal[i] * perSecCount[i];
            secNum[roopNum] += (perSecVal[i] * perSecCount[i]);
            InstantiateTime(i);
        }
        secNum[roopNum] += clickedNum;
		foreach(float i in secNum){
			aveSum += i;
		}
		aveNum = aveSum;
		aveSum = 0;
		roopNum++;
		clickedNum = 0;
		if(roopNum == 50)roopNum = 0;
	}

    public void NeedMoneySum(int arrayNum) {
        if(perSecCount[arrayNum] != 0) {
            perSecNeedMoney[arrayNum] =Mathf.FloorToInt(perSecNeedMoneyDef[arrayNum] + perSecNeedMoney[arrayNum] * moneyUpTimes * perSecCount[arrayNum]);
        }
    }

    void InstantiateTime(int arrayNum) {
        if(perSecCount[arrayNum] <= 4 && perSecCount[arrayNum]!=0) {
            if((10 / perSecCount[arrayNum]) <= timeCounter[arrayNum]) {
                if(parentObject.transform.childCount < 30) LocalInstantiate(arrayNum);
                timeCounter[arrayNum] = 0;
            }
        } else if(4 < perSecCount[arrayNum]) {
            if(!getTime[arrayNum]) {
                dropTime[arrayNum] = Random.Range(2.3f, 3.0f);
                getTime[arrayNum] = true;
            }
            if(dropTime[arrayNum] <= timeCounter[arrayNum]){
                if(parentObject.transform.childCount < 30) LocalInstantiate(arrayNum);
                timeCounter[arrayNum] = 0;
                getTime[arrayNum] = false;
            }
        }
        if(perSecCount[arrayNum]!=0)timeCounter[arrayNum] += Time.deltaTime;
    }
    void LocalInstantiate(int objNum) {
        float randPos;
        GameObject tempObject;
        randPos = Random.Range(-9.0f, 9.0f);
        tempObject = Instantiate((GameObject)perSecDropHeadObject[objNum]) as GameObject;
        tempObject.transform.position = new Vector3(randPos, 22, 0);
        tempObject.transform.parent = parentObject.transform;
    }
}
