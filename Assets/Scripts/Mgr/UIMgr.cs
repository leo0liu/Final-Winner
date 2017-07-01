using UnityEngine;
using System.Collections;

public class UIMgr : MonoBehaviour {

  public void Inst()
    {
        gameSet = GameObject.FindWithTag("LoginCanvas").GetComponent<GameSet>();
        gameSet.Inst();
        choiseBallPos = GameObject.FindWithTag("LoginCanvas").GetComponent<ChoiseBalPos>();
        settingView = GameObject.FindWithTag("LoginCanvas").GetComponent<SettingView>();
        //控制踢球位置类
        choiseMgr = gameObject.AddComponent<ChoiseMgr>();
        choiseMgr.Inst();
    }

    //设置确认任意球位置类
    public GameSet gameSet
    {
        get;
        private set;
    }

    //选择踢球部位类
    public ChoiseBalPos choiseBallPos
    {
        get;
        private set;
    }

    //设置视窗类
    public SettingView settingView

    {
        get;
        private set;
    }

    //控制踢球位置类
    public ChoiseMgr choiseMgr
    {
        get;
        private set;
    }


}
