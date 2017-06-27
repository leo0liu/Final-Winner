using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiseBalPos : MonoBehaviour
{
    //踢球点
    GameObject choiseTickPoint;

    Camera mainCamera;

    public void Inst()
    {
        //choiseTickPoint = transform.Find("ChoiseTickPoint").gameObject;
        //mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    void Start()
    {

    }

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mouPos = Input.mousePosition;

        //    Debug.Log(mainCamera.WorldToScreenPoint(choiseTickPoint.transform.position)); 
        //    if ((mouPos.x>80)&&(mouPos.x<270)&&(mouPos.y>1650)&&(mouPos.y<1850))
        //    {
        //        choiseTickPoint.transform.position = mouPos;
        //    }
           

        //    Debug.Log(Input.mousePosition);

        //}
    }
}
