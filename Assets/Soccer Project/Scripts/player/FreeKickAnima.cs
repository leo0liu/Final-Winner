using UnityEngine;
using System.Collections;

public class FreeKickAnima : MonoBehaviour {

    bool istrue = false;
    GameObject kickPoint;

    void  Awake()
    {
        kickPoint = GameObject.FindWithTag("kickPoint");
    }

	void Update () {
        if (istrue)
        {
            FreeKickMoveAnima();
        } 
    }

    void FreeKickMoveAnima() 
    {
        istrue = true;

       // kickPoint= new Vector3(-37.45f, 0f, -1.06f);

        transform.position = Vector3.MoveTowards(transform.position, kickPoint.transform.position, 1.9f * Time.deltaTime);      

        if (Vector3.Distance(transform.position, kickPoint.transform.position) < 0.1f)
        {

        }

    }
}
