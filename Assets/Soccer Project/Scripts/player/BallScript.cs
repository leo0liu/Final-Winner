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
        forcePosition = transform.Find("forcePosition").gameObject;

    }

    void Start()
    {
     
    }


    void Update()
    {
        if (istrue)
        {


            PauseTimer -= Time.deltaTime;
            if (PauseTimer <= 0)
            {

                for (float i = 0; i < 0.35f; i+=0.05f)
                {

                    ballRig.AddForce(Vector3.back * i, ForceMode.Impulse);
                  
                }
                
            }

            EndTimer -= Time.deltaTime;
            if (EndTimer<=0)
            {
                istrue = false;
            }
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name== "Bip001 R Toe0")
        {
           //  ballRig.AddForce(Vector3.left*180,ForceMode.Impulse);
            ballRig.AddForceAtPosition(Vector3.left*220f,forcePosition.transform.position*100f,ForceMode.Impulse);
            ballRig.AddForce(Vector3.up*40,ForceMode.Impulse);
            istrue = true;
            

        }
    }
}
