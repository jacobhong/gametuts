﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    private void OnTriggerEnter()
    {
        //scoreBox.GetComponent<Text>().text = "1000";
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
