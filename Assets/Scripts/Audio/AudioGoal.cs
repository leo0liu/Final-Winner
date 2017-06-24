﻿using UnityEngine;
using System.Collections;

public class AudioGoal : MonoBehaviour
{

    AudioSource audioGoal;

    //只响一次
    bool isOne=true;

    void Start()
    {
        audioGoal = GetComponent<AudioSource>();
    }

    //void Update () {

    //}
    void OnTriggerEnter(Collider other)
    {
        if (isOne) {
            if (other.name == "Ball")
            {
                audioGoal.Play();
            }
            isOne = false;
        }
    }
}
