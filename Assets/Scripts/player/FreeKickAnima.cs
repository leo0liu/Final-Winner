using UnityEngine;
using System.Collections;

public class FreeKickAnima : MonoBehaviour {

    bool istrue = false;

    //人物移动到踢球点的参照目标点
    GameObject kickPoint;

    void  Awake()
    {
        kickPoint = GameObject.FindWithTag("kickPoint");
    }

	void Update () {
        if (istrue)
        {
            FreeKickMoveAnima();
        } 
    }

    //配合跑步动画的位移方法
    void FreeKickMoveAnima() 
    {
        istrue = true;

        //以目标点为目标位置以恰当的速度配合动画协调的跑到位置上
        transform.position = Vector3.MoveTowards(transform.position, kickPoint.transform.position, 1.9f * Time.deltaTime);      

    }
}
