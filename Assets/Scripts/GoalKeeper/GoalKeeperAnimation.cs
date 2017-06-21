using UnityEngine;
using System.Collections;

public class GoalKeeperAnimation : MonoBehaviour {

    //守门员动画系统
    Animation GoalKeeperAnima;

    void Awake()
    {
        GoalKeeperAnima = GameObject.FindWithTag("GoalKeeper").GetComponent <Animation>();
    }

	//void Start () {
	
	//}
	
	//void Update () {
	
	//}

    //中间部位轻松拿到球
     void MiddleGetBall()
    {

    }
    //左上接球
    void leftUpPickUpBall()
    {
        GoalKeeperAnima.Play();
    }

    //左上挡球
    void leftUpBlockBall()
    {

    }
    
    //右上接球
    void RightUpPickUp()
    {

    }

    //右上挡球
    void RightUpBlock()
    {

    }

    //左下接球
    void leftDownPickUpBall()
    {

    }

    //左下挡球
    void leftDownBlockBall()
    {

    }

    //右下接球
    void RightDownPickUp()
    {

    }

    //右下挡球
    void RightDownBlock()
    {

    }

}
