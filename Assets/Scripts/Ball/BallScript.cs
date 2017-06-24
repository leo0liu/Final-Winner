using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    //球的刚体
    Rigidbody ballRig;

    //球的击球点
    GameObject forcePosition;

    //球在击出一刹那没有旋转的飞行时间
    float PauseTimer = 0.001f;

    //球在击出一刹那没有旋转的飞行时间
    float EndTimer = 0.8f;

    //球在击出时,是否让其带有弧度的旋转
    bool istrue = false;

    //球的力量变量
    public int ballPower;

    //球的高度变量
    public int ballHigh;

    //球的弧度变量
    public float ballRadian;

    //守门员的位置
    GameObject goalKeeperTarget;

    //是否看守门员
    public bool isLookAtKeeper=true;

    void Awake()
    {
        ballRig = GetComponent<Rigidbody>();
        forcePosition = GameObject.Find("forcePosition");
        goalKeeperTarget = GameObject.FindWithTag("GoalKeeper");

    }

    //void Start()
    //{
    //}


    void Update()
    {
        if (isLookAtKeeper) {
            transform.LookAt(goalKeeperTarget.transform.position);
            isLookAtKeeper = false;
        }
        //当球在击出时需要旋转时
        if (istrue)
        {
            PauseTimer -= Time.deltaTime;
            if (PauseTimer <= 0)
            {
                for (float i = 0; i < ballRadian; i+=0.05f)
                {
                    //给弧线的力度
                    ballRig.AddForce(Vector3.back * i, ForceMode.Impulse);
                    transform.Rotate(Vector3.up,35f);
                }          
            }
            //结束弧线
            EndTimer -= Time.deltaTime;
            if (EndTimer<=0)
            {
                istrue = false;
            }
            
        }
    }

    //当玩家的脚接触到球的时候
    void OnTriggerEnter(Collider other)
    {
        if (other.name== "Bip00RToe0")
        {

            //给一个带有使球旋转的的击球力度
            ballRig.AddForceAtPosition(transform.forward*ballPower,forcePosition.transform.position*100f,ForceMode.Impulse);

            //球击出后给一个向上的力量
            ballRig.AddForce(Vector3.up*ballHigh,ForceMode.Impulse);

            //是否需要弧线
            istrue = true;
        }
    }

    //当人物每次移动的时候,球绕Y轴旋转10F
   public  void LeftRotate()
    {
        transform.Rotate(transform.up,2f);
    }

   public  void RightRotate()
    {
        transform.Rotate(transform.up, -2f);
    }
    
    //踢球时,让刚体的冻结解除
    public void RigReset()
    {
        ballRig.constraints = RigidbodyConstraints.None;
    }
   
}
