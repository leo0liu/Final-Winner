using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSet : MonoBehaviour {

    //设置球体位置的Button
    Button gameSet;

    //gameSet主体
    GameObject gameSetSelf;

    //二号摄像机
    GameObject cameraTwo;

    //主摄像机
    Camera mainCamera;

    //区域限制墙
    GameObject limitWar;

    //选择性用球
    GameObject choiseBall;

    //选择提示语
    GameObject choisePrompt;

    //选择踢球部位的UI
    GameObject choisePos;

   public void Inst()
    {
        gameSet = transform.Find("GameSet").GetComponent<Button>();
        gameSetSelf = transform.Find("GameSet").gameObject;
        cameraTwo = GameObject.FindWithTag("CameraTwo");
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        limitWar = GameObject.FindWithTag("LimitWar");
        choiseBall = GameObject.FindWithTag("ChoiseBall");
        choisePrompt = transform.Find("ChoisePrompt").gameObject;
        choisePos = transform.Find("ChoiseBall").gameObject;
    }

	void Start () {
        gameSet.onClick.AddListener(ButtonGameSet);
    }
	
	void Update () {

    }

    //当按下任意球设置按钮后
    void ButtonGameSet()
    {
        //二号摄像机失效
        cameraTwo.SetActive(false);
        //主摄像机Camera组件启动
        mainCamera.enabled = true;
        //限制提示墙失效
        limitWar.SetActive(false);
        //选择球失效
        choiseBall.SetActive(false);
        //提示语失效
        choisePrompt.SetActive(false);
        //选择定位球控制类失效
        Global._instance.choiseMgr.enabled = false;
        //自己本身失效
        gameSetSelf.SetActive(false);
        //让足球看着守门员
        Global._instance.ball.isLookAtKeeper=true;
        //让守门员注视足球
        Global._instance.goalkeeperMgr.goalKeeperCatchMove.isLookBall = true;
        //让选择踢球部位UI显示
        choisePos.SetActive(true);
    }

    //让提示语的颜色渐变
    void PromptFlash()
    {

        float a = choisePrompt.GetComponent<Text>().material.color.a;
        a = 0f;
    }

}
