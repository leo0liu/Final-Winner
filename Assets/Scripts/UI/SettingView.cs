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

    void Inst()
    {
        settingButton = transform.Find("settingButton").GetComponent<Button>();
        settingButton.onClick.AddListener(OpenSettingView);
        settingView = transform.Find("SettingView").gameObject;
        cancelButton = transform.Find("SettingView/CanceButton").GetComponent<Button>();
        cancelButton.onClick.AddListener(cancelSettingButton);
        ReturnMenu = transform.Find("SettingView/ReturnButton").GetComponent<Button>();
        ReturnMenu.onClick.AddListener(ReturnMenuButton);
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
    }

    //当按下取消设置按钮
    void cancelSettingButton()
    {
        settingView.SetActive(false);
    }

    //当按下返回主菜单按钮
    void ReturnMenuButton()
    {
        SceneManager.LoadScene(4);
    }
}
