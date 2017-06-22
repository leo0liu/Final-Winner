﻿using UnityEngine;
using System.Collections;

public class GoalKeeperCatchMove : MonoBehaviour {

    Rigidbody keeperRig;
    void Awake()
    {
        keeperRig = GetComponent<Rigidbody>();
 
    }

	void Start () {
	
	}
	
	void Update () {
	
	}
    
    //右接球位移
   public void CatchMoveRightPickUp()
    {
        keeperRig.AddForce(Vector3.up * 200, ForceMode.Impulse);
        keeperRig.AddForce(Vector3.back*300f,ForceMode.Impulse);
    }

    //右挡球位移
    public void CatchMoveRightBlock()
    {
        keeperRig.AddForce(Vector3.up * 400, ForceMode.Impulse);
        keeperRig.AddForce(Vector3.back * 450f, ForceMode.Impulse);
    }

    //左接球位移
    public void CatchMoveLeftPickUp()
    {
        keeperRig.AddForce(Vector3.up * 200, ForceMode.Impulse);
        keeperRig.AddForce(Vector3.forward * 300f, ForceMode.Impulse);
    }

    //左挡球位移
    public void CatchMoveLeftBlock()
    {
        keeperRig.AddForce(Vector3.up*400,ForceMode.Impulse); 
        keeperRig.AddForce(Vector3.forward * 450f, ForceMode.Impulse);
    }
}
