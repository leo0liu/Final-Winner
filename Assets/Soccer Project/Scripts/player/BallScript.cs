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

    void Awake()
    {
        ballRig = GetComponent<Rigidbody>();
        forcePosition = GameObject.Find("forcePosition");

    }

    void Start()
    {
     
    }


    void Update()
    {
        //当球在击出时需要旋转时
        if (istrue)
        {
            PauseTimer -= Time.deltaTime;
            if (PauseTimer <= 0)
            {
                for (float i = 0; i < 0.45f; i+=0.05f)
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
        if (other.name== "Bip001 R Toe0")
        {
           //  ballRig.AddForce(Vector3.left*180,ForceMode.Impulse);

            //给一个带有弧度的击球力度
            ballRig.AddForceAtPosition(Vector3.left*200f,forcePosition.transform.position*100f,ForceMode.Impulse);

            //球击出后给一个向上的力量
            ballRig.AddForce(Vector3.up*42,ForceMode.Impulse);

            //是否需要弧线
            istrue = true;
            

        }
    }
}
