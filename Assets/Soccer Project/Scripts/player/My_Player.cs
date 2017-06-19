using UnityEngine;
using System.Collections;

public class My_Player : MonoBehaviour {

    Animator ContrFreeTick;

    void Awake()
    {
        ContrFreeTick = GetComponent<Animator>();
    }

	void Start () {
	
	}
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ContrFreeTick.SetTrigger("freeKick");
        }
	}
}
