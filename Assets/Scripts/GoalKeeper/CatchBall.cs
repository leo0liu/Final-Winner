using UnityEngine;
using System.Collections;

public class CatchBall : MonoBehaviour {

    //该类用来作为守门员前方碰撞器的检测


    //只触发一次
    bool isTrue = true;

    //让球被接住后保持在守门员的手上
    bool isCatchBall = false;

    //守门门员的手指,也就是接球后的父物体
    GameObject goalKeeperFinger;

    //守门员身后的墙
    Collider wall;

    SphereCollider Ball;

    void Awake()
    {
        goalKeeperFinger = GameObject.FindWithTag("Bip001 R Finger0");
        Ball = GameObject.FindWithTag("Ball").GetComponent<SphereCollider>();
        wall = GameObject.FindWithTag("Trigger_wall").GetComponent<Collider>(); ;
    }

	void Start () {
	
	}
	
	void Update () {
        if (isCatchBall)
        {
            gameObject.transform.parent = goalKeeperFinger.transform;
            gameObject.transform.localPosition = new Vector3(-2.4f, 4.599954f, 2.6f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (isTrue) {

            if (other.name == "Trigger_Up_Left(1)") //左上拿
            {
                Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.leftUpPickUpBall();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveLeftPickUp();
                isCatchBall = true;
                isTrue = false;

            }

            if (other.name == "Trigger_Up_Left (2)") //左上挡
            {
               // Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.leftUpBlockBall();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveLeftBlock();
                wall.isTrigger = false;
                // isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Up_Left (3)") //左上扑
            {
                //Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.leftUpBlockBall();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveLeftBlock();
                //isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Up_right (3)") //右上拿
            {
                Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.RightUpPickUp();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveRightPickUp();
                isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Up_right (2)") //右上挡
            {
              //  Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.RightUpBlock();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveRightBlock();
                wall.isTrigger = false;
                //isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Up_right (1)") //右上扑
            {
               // Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.RightUpBlock();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveRightBlock();
               // isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Middle") //中间接
            {
                Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.MiddleGetBall();
                isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Down_right (4)") //右下扑
            {
                //Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.RightDownBlock();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveRightBlock();
              //  isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Down_right (5)") //右下挡
            {
                //Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.RightDownBlock();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveRightBlock();
                wall.isTrigger = false;
                // isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Down_right (6)") //右下拿
            {
                Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.RightDownPickUp();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveRightPickUp();
                isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Down_Left (4)") //左下扑
            {
                //Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.leftDownBlockBall();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveLeftBlock();
              // isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Down_Left (5)") //左下挡
            {
                //Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.leftDownBlockBall();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveLeftBlock();
                wall.isTrigger = false;
               // isCatchBall = true;
                isTrue = false;
            }

            if (other.name == "Trigger_Down_Left (1)") //左下拿
            {
                Ball.isTrigger = true;
                Global._instance.goalkeeperMgr.goalKeeperAnimation.leftDownPickUpBall();
                Global._instance.goalkeeperMgr.goalKeeperCatchMove.CatchMoveLeftPickUp();
                isCatchBall = true;
                isTrue = false;
            }

        }
    }


    void OnTriggerExit(Collider other)
    {

    }
}
