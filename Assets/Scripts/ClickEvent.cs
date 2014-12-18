using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour {

	public CountManager cManager;
    public GameObject[] dropObject = new GameObject[1];
    public GameObject parentObject;
    private int randObjNum;

	// Use this for initialization
	void Start () {
		cManager = GetComponent<CountManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void ScreenClick(){
		cManager.sum += cManager.perClick;
		cManager.clickSum += cManager.perClick;
		cManager.clickedNum += cManager.perClick;
        randObjNum = Random.Range(0, dropObject.Length);
        LocalInstantiate(randObjNum);
	}

    void LocalInstantiate(int dropObjectNum) {
        float randPos;
        GameObject tempObject;
        randPos = Random.Range(-9.0f, 9.0f);
        tempObject = Instantiate(dropObject[dropObjectNum]) as GameObject;
        tempObject.transform.position = new Vector3(randPos, 22, 0);
        tempObject.transform.parent = parentObject.transform;
    }
}