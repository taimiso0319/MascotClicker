using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour {

	public CountManager cManager;
    public GameObject[] dropObject = new GameObject[1];
    public GameObject parentObject;
    private int randObjNum;
    public AudioClip audioClip;
    private AudioSource audioSource;
    private int clickCount = 0;

	// Use this for initialization
	void Start () {
		cManager = GetComponent<CountManager>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
	}
	
	public void ScreenClick(){
		cManager.sum += cManager.perClick;
		cManager.clickSum += cManager.perClick;
		cManager.clickedNum += cManager.perClick;
        randObjNum = Random.Range(0, dropObject.Length);
        clickCount++;
        if(parentObject.transform.childCount < 30 && clickCount == 5) {
            LocalInstantiate(randObjNum);
            clickCount = 0;
        }
            audioSource.Play();
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