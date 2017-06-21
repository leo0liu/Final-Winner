using UnityEngine;
using System.Collections;

public class CatchBall : MonoBehaviour {

    //该类用来作为守门员前方碰撞器的检测

    //使其他碰撞器失效
    bool isTrue = true;

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Trigger_Up_Left(1)") //左上拿
        {


            return;
        }

        if (other.name == "Trigger_Up_Left (2)") //左上挡
        {


            return;
        }

        if (other.name == "Trigger_Up_Left (3)") //左上扑
        {


            return;
        }

        if (other.name == "Trigger_Up_right (3)") //右上拿
        {


            return;
        }

        if (other.name == "Trigger_Up_right (2)") //左上挡
        {


            return;
        }

        if (other.name == "Trigger_Up_right (1)") //左上扑
        {


            return;
        }

        if (other.name == "Trigger_Middle") //中间接
        {


            return;
        }

        if (other.name == "Trigger_Down_right (4)") //右下扑
        {


            return;
        }

        if (other.name == "Trigger_Down_right (5)") //右下挡
        {


            return;
        }

        if (other.name == "Trigger_Down_right (6)") //右下拿
        {


            return;
        }

        if (other.name == "Trigger_Down_Left (4)") //左下扑
        {


            return;
        }

        if (other.name == "Trigger_Down_Left (5)") //左下挡
        {


            return;
        }

        if (other.name == "Trigger_Down_Left (1)") //左下拿
        {


            return;
        }

    }


    void OnTriggerExit(Collider other)
    {

    }
}
