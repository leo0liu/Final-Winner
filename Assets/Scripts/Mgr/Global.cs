﻿using UnityEngine;
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
        DontDestroyOnLoad(gameObject);
        inst= this;
        AddScript();
    }

    //添加所有脚本到全局类身上方便调用
    void AddScript()
    {
        //获取UI管理
        uiMgr = gameObject.AddComponent<UIMgr>();
        uiMgr.Inst();

        //获取守门员管理
        goalkeeperMgr = gameObject.AddComponent<GoalKeeperMgr>();
        goalkeeperMgr.Inst();

        //获取摄像机管理类
        cameraMgr = gameObject.AddComponent<CameraMgr>();
        cameraMgr.Inst();

        //获取足球类
        ball = GameObject.FindWithTag("Ball").GetComponent<BallScript>();


    }

    //UI管理类
    public UIMgr uiMgr
    {
        get;
        private set;
    }

    //守门员管理类
    public GoalKeeperMgr goalkeeperMgr
    {
        get;

        private set;
    }

    //摄像机管理类
    public CameraMgr cameraMgr
    {
        get;
        private set;
    }

    //足球类
    public BallScript ball
    {
        get;
        private set;
    }


}
