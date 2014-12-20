using UnityEngine;
using System.Collections;

public class SplashChange : MonoBehaviour {

	public GameObject plane;
	public float timer = 7.0f;
	public float transTimer = 4.0f;
	public int transInt = 0;

	void Start(){
		transInt = Mathf.FloorToInt(255/(50*(transTimer-1)));
	}

	// Update is called once per frame
	void FixedUpdate () {
		timer -= Time.deltaTime;
		if(timer < transTimer){
			renderer.material.color += new Color32(0,0,0,(byte)transInt);
		}
		if(timer < 0)Application.LoadLevel(1);
	}
}
