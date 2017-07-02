using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingView : MonoBehaviour {

    //设置按钮
    Button settingButton;

    //设置视窗
    GameObject settingView;

    //取消设置视窗按钮
    Button cancelButton;

    //返回主菜单按钮
    Button ReturnMenu;

    //当设置视窗被激活时
    public bool isSettingView = true;

    //重新原地踢球
    public GameObject originTickGame;
    //重新选择主罚点
    public GameObject choiseTickPositonGame;

    //重新原地踢球按钮
    Button originTickButton;

    //重新选择主罚点按钮
    Button choiseTickPositionButton;

	//设置音量控件
	Slider musicSlider;

	//关闭音乐按钮
	Toggle musicToggle;

	//音量Mgr

	GameObject audioMgr;


    void Inst()
    {
        settingButton = transform.Find("settingButton").GetComponent<Button>();
        settingButton.onClick.AddListener(OpenSettingView);
        settingView = transform.Find("SettingView").gameObject;
        cancelButton = transform.Find("SettingView/CanceButton").GetComponent<Button>();
        cancelButton.onClick.AddListener(cancelSettingButton);
        ReturnMenu = transform.Find("SettingView/ReturnButton").GetComponent<Button>();
        ReturnMenu.onClick.AddListener(ReturnMenuButton);
        originTickGame = transform.Find("OriginTickButton").gameObject;
        choiseTickPositonGame = transform.Find("ChoiseTickPositonButton").gameObject;
        originTickButton = originTickGame.GetComponent<Button>();
        originTickButton.onClick.AddListener(OpenOriginButton);
        choiseTickPositionButton = choiseTickPositonGame.GetComponent<Button>();
        choiseTickPositionButton.onClick.AddListener(OpenChoiseButton);

		musicSlider = transform.Find ("SettingView/MusicSlider").GetComponent<Slider>();
		musicSlider.onValueChanged.AddListener (delegate (float a){ ControlMusic(a);});

		musicToggle = transform.Find ("SettingView/MusicToggle").GetComponent<Toggle>();
		musicToggle.onValueChanged.AddListener (delegate (bool a){ControlMusicSwitch( a);});
		audioMgr = GameObject.FindWithTag ("AudioMgr");
    }


	void Start () {
        Inst(); 
	}
	
	void Update () {
		
	}

    //当按下设置按钮,弹窗
    void OpenSettingView()
    {
        settingView.SetActive(true);
        isSettingView = false;
    }

    //当按下取消设置按钮
    void cancelSettingButton()
    {
        settingView.SetActive(false);
        isSettingView = true;
    }

    //当按下返回主菜单按钮
    void ReturnMenuButton()
    {
        SceneManager.LoadScene(4);
    }

    //当按下原地重新踢球按钮后
    void OpenOriginButton()
    {
        SceneManager.LoadScene(3);
       // Global._instance.uiMgr.gameSet.ButtonGameSet();
       // Global._instance.uiMgr.choiseMgr.choisePosition.transform.position = Global._instance.uiMgr.choiseMgr.orginPoint;
    }

    //当按下重新选择任意球主罚点按钮后
    void OpenChoiseButton()
    {
        //SceneManager.LoadScene(3);
    }

	//控制音量大小
	void ControlMusic(float a){
		audioMgr.GetComponent<AudioSource> ().volume = a;
	}

	//控制音量开关
	void ControlMusicSwitch(bool a){
		audioMgr.GetComponent<AudioSource> ().enabled = a;
	}
}
