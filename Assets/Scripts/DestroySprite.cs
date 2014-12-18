﻿using UnityEngine;using System.Collections;public class DestroySprite : MonoBehaviour {    private float defSpeed = 2.0f;    public float destroySpeed = 0;    public GameObject parentObject;    void Start(){        destroySpeed = defSpeed;    }    void OnCollisionEnter2D(Collision2D col) {        if(parentObject == null) destroySpeed = 0;        else {            if((destroySpeed = defSpeed - (0.05f * parentObject.transform.childCount)) <= 0) {                destroySpeed = 0;            }        }        Destroy(col.gameObject, destroySpeed);    }}