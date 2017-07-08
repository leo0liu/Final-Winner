using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropMgr : MonoBehaviour
{

    public void Inst()
    {
        target = GameObject.FindWithTag("targerPoint").GetComponent<TargetScript>();
    }


    void Start()
    {
        Inst();
    }

    void Update()
    {

    }

    public TargetScript target{
        get;
        private set;

    }
}
