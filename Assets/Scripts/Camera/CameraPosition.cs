using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

    //设置父物体
    GameObject globalMgr;

    //开始时注视的位置
    GameObject goalKeeper;

    //是否保持注视
    bool isLookAt = true;

    void Awake()
    {
        globalMgr = GameObject.FindWithTag("GlobalMgr");
        goalKeeper = GameObject.FindWithTag("GoalKeeper");
    }

    void Start()
    {
      //  Debug.Log("333");
      //  transform.LookAt(goalKeeper.transform.position);
    }

    void Update()
    {
        //游戏一开始看着守门员
        //if (isLookAt) {
        //    transform.LookAt(goalKeeper.transform.position);
        //    isLookAt = false;
        //}
    }

    //改变自己的父物体
    public void ChangeParent()
    {
        transform.SetParent(globalMgr.transform);
    }
}
