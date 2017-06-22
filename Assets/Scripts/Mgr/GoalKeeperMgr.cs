using UnityEngine;
using System.Collections;

public class GoalKeeperMgr : MonoBehaviour {



    void Awake()
    {
        Inst();
    }

    public void Inst()
    {
        //定义守门员动画类
        goalKeeperAnimation = GameObject.FindWithTag("GoalKeeper").GetComponent<GoalKeeperAnimation>();

        //定义守门员碰撞检测类
        catchBall = GameObject.FindWithTag("Ball").GetComponent<CatchBall>();

        //定义守门员扑救球的位置移动类
        goalKeeperCatchMove = GameObject.FindWithTag("GoalKeeper").GetComponent<GoalKeeperCatchMove>();
    }

    void Start () {
	   
	}
	
	void Update () {
	   
	}
      
    // 守门员守门的碰撞检测类
    public CatchBall catchBall       
    {
        get;
       private set;      
    }

    // 守门员的所有动画播放类
    public GoalKeeperAnimation goalKeeperAnimation
    {
        get;
        private set;
    }

    // 守门员飞身扑救球的自身位置移动
    public GoalKeeperCatchMove goalKeeperCatchMove
    {
        get;
        private set;
    }
}
