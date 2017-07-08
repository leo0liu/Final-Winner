using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPositon : MonoBehaviour
{

	//保存上一次的任意球位置
	public static Vector3 choPositon;

	//任意球的物体
	GameObject choisePosition;

	public static MemoryPositon instance;

    static MemoryPositon (){
        GameObject go = new GameObject("MemoryPositon");
        DontDestroyOnLoad(go);
        instance = go.AddComponent<MemoryPositon>();
    }

    void Awake()
    {
       
    }

    //按下原地再次踢球后间隔0.02秒后再运行切换
    public void DoSome(){
        Invoke("OiginTick", 0.02f);
	}

    //原地再次踢球的方法
    void OiginTick(){
        choisePosition = GameObject.FindWithTag("ChoisePositon");
        choisePosition.transform.position = choPositon;
        Global._instance.uiMgr.gameSet.ButtonGameSet();
    }
}
