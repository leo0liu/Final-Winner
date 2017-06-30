using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChoiseBalPos : MonoBehaviour
{
    //踢球点
   public GameObject choiseTickPoint;

    //踢球的力量条
    public Slider power;

    //力量变量
    public int powerVal;

    public void Inst()
    {
        choiseTickPoint = transform.Find("ChoiseBall/ChoiseTickPoint").gameObject;
        power = transform.Find("ChoiseBall/Power").GetComponent<Slider>();
    }

    void Awake()
    {
        Inst();
    }

    void Start()
    {
    }

    void Update()
    {
        ChoiseTickPointVec();
        powerVal = (int)power.value;
    }

    //使选择踢球点与鼠标点击点相等
   public Vector3 ChoiseTickPointVec()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mouPos = Input.mousePosition;
            if ((mouPos.x > 1650) && (mouPos.x < 1850) && (mouPos.y > 80) && (mouPos.y < 270))
            {

                choiseTickPoint.transform.position = mouPos;
            }
        }
        return choiseTickPoint.transform.position;
    }

    
}
