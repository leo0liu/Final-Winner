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

    //球在击出一刹那没有旋转的结束时间
    float EndTimer = 0.8f;

    //球在击出时,是否让其带有弧度的旋转
    bool istrue = false;

    //球的力量变量
    int ballPower;

    //球的高度变量
     int ballHigh ;

    //球的弧度变量
     float ballRadian;

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
                ballRadian=mathPositon(); 
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
              //  Global._instance.
            }
            
        }
    }
    

    //当玩家的脚接触到球的时候
    void OnTriggerEnter(Collider other)
    {
        if (other.name== "Bip00RToe0")
        {
            //得到力量的实时变量
            ballPower = Global._instance.uiMgr.choiseBallPos.powerVal;
            //给一个带有使球旋转的的击球力度
            ballRig.AddForceAtPosition(transform.forward*ballPower,forcePosition.transform.position*100f,ForceMode.Impulse);
            //得到高度力量的实时变量
            ballHigh = (int)((270f-Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.y) / 2.375f);
            //球击出后给一个向上的力量
            ballRig.AddForce(Vector3.up* ballHigh, ForceMode.Impulse);

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

    //计算弧度位置14个点的具体Float值
     float mathPositon()
    {      
        if (Global._instance.uiMgr.choiseBallPos .choiseTickPoint.transform.position.x>=1650&& Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x<=1664)
        {
            ballRadian = 0.05f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1664 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1678)
        {
            ballRadian = 0.1f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x >1678 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1692)
        {
            ballRadian = 0.15f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1692 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1706)
        {
            ballRadian = 0.2f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1706 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1720)
        {
            ballRadian = 0.25f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1720 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1734)
        {
            ballRadian = 0.3f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1734 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1748)
        {
            ballRadian = 0.35f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1748 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1762)
        {
            ballRadian = 0.4f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1762 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1776)
        {
            ballRadian = 0.45f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x >1776 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1790)
        {
            ballRadian = 0.5f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1790 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1804)
        {
            ballRadian = 0.55f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x >1804 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1818)
        {
            ballRadian = 0.6f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1818 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1832)
        {
            ballRadian = 0.65f;
            return ballRadian;
        }

        if (Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x > 1832 && Global._instance.uiMgr.choiseBallPos.choiseTickPoint.transform.position.x <= 1846)
        {
            ballRadian = 0.7f;
            return ballRadian;
        }
        return ballRadian;
    }
   
}
