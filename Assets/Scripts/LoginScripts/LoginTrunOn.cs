using UnityEngine;
using System.Collections;

public class LoginTrunOn : MonoBehaviour
{

    GameObject start;
    GameObject image;
    void Awake()
    {
        start = transform.Find("Start").gameObject;
        image = transform.Find("Image").gameObject;
        Invoke("loginTurnOn", 4.48f);
    }

    //void Start () {

    //}

    //void Update () {

    //}

    void loginTurnOn()
    {
        start.SetActive(true);
        image.SetActive(true);
    }
}
