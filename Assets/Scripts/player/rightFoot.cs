using UnityEngine;
using System.Collections;

public class rightFoot : MonoBehaviour {



    //    //当右脚碰到球播放音效
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
             Global._instance.audioMgr.kickBall.KickBallAudio();
        }
    }
}
