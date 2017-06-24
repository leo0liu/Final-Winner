using UnityEngine;
using System.Collections;

public class PlayerMgr : MonoBehaviour {

    

   public  void Inst()
    {
        player = GameObject.FindWithTag("Player").GetComponent<My_Player>();
    }

    void Awake()
    {

    }

	void Start () {
	
	}
	
	void Update () {
	
	}

   public My_Player player
    {
        get;
        private set;
    }
}
