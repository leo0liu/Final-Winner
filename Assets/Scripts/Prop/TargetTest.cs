using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTest : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other){
        if(other.name=="Ball"){
            Global._instance.propMgr.target.isTrue = true;
        }
    }
}
