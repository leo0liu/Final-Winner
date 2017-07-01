using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryLocationScript : MonoBehaviour {


    public GameObject CloneTemp;

    public static bool IsHaveUsed = false;

    private GameObject clone;

    void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);

    }
    // Use this for initialization
    void Start()
    {

        //if (!GameObject.Find("Root(Clone)"))
        if (!IsHaveUsed)
        {
            clone = Instantiate(CloneTemp, transform.position, transform.rotation) as GameObject;

            IsHaveUsed = true;
            DontDestroyOnLoad(clone.transform.gameObject);
        }





    }

  
}