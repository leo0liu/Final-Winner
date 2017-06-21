using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {
    #region 单例
    private static Global inst;

    public static Global _instance
    {
        get
        {
            return inst;
        }
    }

    #endregion

    void Awake()
    {
        inst= this;
    }

    UIMgr uiMgr;

    void AddScript()
    {
        uiMgr = transform.Find("UIMgr").GetComponent<UIMgr>();
    }

	void Start () {
	
	}
	
	void Update () {
	
	}

}
