using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {
    //目标点
    GameObject targer;

    //蓝光粒子
    GameObject blueLight;

    //橙色光特效
    GameObject OrangeLight;

    //如果被足球射中
   public bool isTrue = false;

    //音乐数组
    public AudioClip[] audioGroup;

    //踢中奖励声音
    AudioClip audio1;

    //喝彩声
    AudioClip audio2;

    //音乐播放组建
    AudioSource audioSource;

    void Awake(){
        targer = transform.Find("Targer").gameObject;
        blueLight = transform.Find("BlueDiscFX").gameObject;
        OrangeLight = transform.Find("OrangeDiscFX").gameObject;
        audioSource = GetComponent<AudioSource>();

    }

	void Start () {
		
	}

    void Update()
    {
        if (isTrue)
        {
            audioPlay();
            //boom_ui出现
            Global._instance.uiMgr.propUI.boom.SetActive(true);
            //美女喜欢UI出现
            Invoke("GirlLike", 2f);
            targer.SetActive(false);
            blueLight.SetActive(false);
            OrangeLight.SetActive(true);
            isTrue = false;

        }
    }
    //播放音效
    void audioPlay(){
       audioSource.Play();
       audioSource.PlayOneShot(audioGroup[0]);
    }

    //美女喜欢UI出现
    void GirlLike(){
        Global._instance.uiMgr.propUI.girl_like.SetActive(true);
    }
}
