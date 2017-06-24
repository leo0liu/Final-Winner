using UnityEngine;
using System.Collections;

public class KickBall : MonoBehaviour {

    AudioSource audioTick;

    void Start()
    {
        audioTick = GetComponent<AudioSource>();
    }

    //void Update () {

    //}

    //踢球时播放音效
   public  void KickBallAudio()
    {
        audioTick.Play();
    }
}
