using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pattern_UI_Button : MonoBehaviour {

    Button choiseNewButton;

    void Awake()
    {
        choiseNewButton = transform.Find("patternChoise/new/Button").GetComponent<Button>();
        choiseNewButton.onClick.AddListener(OpenNewButton);
    }

	void Start () {
		
	}
	
	void Update () {
		
	}

    //打开练习模式按钮
    void OpenNewButton()
    {
        SceneManager.LoadScene(3); 
    }
}
