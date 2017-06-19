using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    Rigidbody ballRig;

    GameObject a;
    GameObject forcePosition;

    float PauseTimer = 0.001f;
    float EndTimer = 0.8f;

    bool istrue = false;

    void Awake()
    {
        ballRig = GetComponent<Rigidbody>();
        forcePosition = transform.Find("forcePosition").gameObject;

        a = GameObject.Find("A");
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

                for (float i = 0; i < 0.4f; i+=0.05f)
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
            ballRig.AddForceAtPosition(Vector3.left*180f,forcePosition.transform.position*100f,ForceMode.Impulse);
            ballRig.AddForce(Vector3.up*43,ForceMode.Impulse);
            istrue = true;
            

        }
    }
}
