using UnityEngine;
using System.Collections;

public class AudioMgr : MonoBehaviour {

    

    public  void Inst()
    {
        kickBall = GameObject.FindWithTag("AuidoKickBall").GetComponent<KickBall>();
        audioGoal = GameObject.FindWithTag("GoalAudio").GetComponent<AudioGoal>();
    }

    void Awake()
    {

    }

	void Start () {
	
	}
	
	void Update () {
	
	}

    //踢球时播放音效的类
    public KickBall kickBall
    {
        get;
        private set;
    }

    //进球时播放的音效类
    public AudioGoal audioGoal
    {
        get;
        private set;
    }
}
