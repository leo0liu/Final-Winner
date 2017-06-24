using UnityEngine;
using System.Collections;

public class My_Player : MonoBehaviour
{

    //踢球动画
    Animator playerCtr;

    //球
    GameObject ball;

    //支撑脚的位置
    GameObject kickPoint;

    //每次只踢一次
    bool isTrue = true;

    //判断不能超过一个左右调整的距离
    bool isOver = true;

    //设置支撑脚的父物体
    GameObject playAndBall;


    void Awake()
    {
        playerCtr = GetComponent<Animator>();
        ball = GameObject.FindWithTag("Ball");
        kickPoint = GameObject.FindWithTag("kickPoint");
        playAndBall = GameObject.FindWithTag("playerball");
    }

    //void Start () {
    //   }


    void Update()
    {

        if (isTrue)
        {
            //按下D键触发踢球动画
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.SetParent(playAndBall.transform);
                Global._instance.ball.RigReset();
                Global._instance.cameraMgr.cameraPosition.ChangeParent();
                kickPoint.transform.SetParent(playAndBall.transform);
                playerCtr.SetTrigger("freeKick");
                isTrue = false;
            }
        }


        if (isOver)
        {
            //当按下左键时,让人物左移动画开始,让人物已球为轴心开始旋转,让球转动2F
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.SetParent(playAndBall.transform);
                playerCtr.SetTrigger("rightWalk");
                transform.RotateAround(ball.transform.position, Vector3.up, 3f);
                Global._instance.ball.LeftRotate();

                //判断是否超过左边极限
                //if ()
                //{

                //}
            }

            //当按下右键时,让人物右移动画开始,让人物已球为轴心开始旋转,让球转动2F
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.SetParent(playAndBall.transform);
                playerCtr.SetTrigger("leftWalk");
                transform.RotateAround(ball.transform.position, Vector3.up, -3f);
                Global._instance.ball.RightRotate();
                //判断是否超过右边极限
                //if ()
                //{

                //}
            }
        }
    }
}

