using UnityEngine;
using System.Collections;

public class LoginAnima : MonoBehaviour {

    Animator logAnim;

    void Awake()
    {
        logAnim = GetComponent<Animator>();
    }

    void StopAnima()
    {
        logAnim.enabled = false;
    }

}
