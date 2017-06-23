using UnityEngine;
using System.Collections;

public class CameraMgr : MonoBehaviour {

    public  void Inst()
    {
        cameraPosition = GameObject.FindWithTag("MainCamera").GetComponent<CameraPosition>();
    }

    void Awake()
    {
        Inst();
    }
  
    //摄像机位置类 
   public CameraPosition cameraPosition
    {
        get;
        private set;
    }
}
