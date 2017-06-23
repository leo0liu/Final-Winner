using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

    //设置父物体
    GameObject globalMgr;


    void Awake()
    {
        globalMgr = GameObject.FindWithTag("GlobalMgr");
    }

    //void Start()
    //{

    //}

    //void Update()
    //{

    //}
    
    //改变自己的父物体
   public void ChangeParent()
    {
        transform.SetParent(globalMgr.transform);
    }
}
