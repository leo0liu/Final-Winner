using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoginScene : MonoBehaviour
{

    Button loginScene;

    void Awake()
    {
        loginScene=GetComponent<Button>();
    }

    void Start()
    {
        loginScene.onClick.AddListener(Login);
    }

    void Update()
    {
       
    }

    void Login()
    {
        SceneManager.LoadScene(3);
    }
}
