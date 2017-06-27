using UnityEngine;
using System.Collections;

public class GoalKeeperCatchMove : MonoBehaviour {

    //此类为守门员守门时的扑球位置类

    Rigidbody keeperRig;

    //游戏开始让守门员注视足球
    GameObject ball;

    //是否让守门员注视足球
    public bool isLookBall=true;

    void Awake()
    {
        keeperRig = GetComponent<Rigidbody>();
        ball = GameObject.FindWithTag("Ball");
 
    }
    void Start()
    {
        
    }
    
    void Update()
    {
        if(isLookBall){
            transform.LookAt(ball.transform.position);
            isLookBall = false;
        }
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
