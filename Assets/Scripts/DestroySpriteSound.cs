﻿using UnityEngine;
using System.Collections;

public class DestroySpriteSound : MonoBehaviour {
    public AudioClip audioClip;    private AudioSource audioSource;    void Start() {        audioSource = GetComponent<AudioSource>();        audioSource.clip = audioClip;    }

    public void PlaySound() {
        audioSource.Play();
    }
}
