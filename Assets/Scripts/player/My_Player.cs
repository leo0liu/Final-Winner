using UnityEngine;
using System.Collections;

public class My_Player : MonoBehaviour {

    //踢球动画
    Animator ContrFreeTick;

    //每次只踢一次
    bool isTrue = true;

    void Awake()
    {
        ContrFreeTick = GetComponent<Animator>();
    }

	void Start () {
	
	}
	

	void Update () {
        if (isTrue)
        {
            //按下D键触发踢球动画
            if (Input.GetKeyDown(KeyCode.D))
            {
                ContrFreeTick.SetTrigger("freeKick");
                isTrue = false;
            }
        }
	}
}
