using UnityEngine;
using System.Collections;

public class FreeKickAnima : MonoBehaviour
{

    bool istrue = false;

    //人物移动到踢球点的参照目标点
    GameObject kickPoint;

    void Awake()
    {
        kickPoint = GameObject.FindWithTag("kickPoint");
    }

    void Update()
    { 

        if (istrue)
        {
            FreeKickMoveAnima();
         
        }
    }

    //配合跑步动画的位移方法(这个类比较特殊,由动画时间调用)
    void FreeKickMoveAnima()
    {
        //时间调用后使循环开始一次
        istrue = true;
         
        //以目标点为目标位置以恰当的速度配合动画协调的跑到位置上
        Vector3 self = transform.position;
          transform.position = Vector3.MoveTowards(self, kickPoint.transform.position, 1.9f * Time.deltaTime);
    }
}
