using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropUI : MonoBehaviour {

    //boom礼花
   public GameObject boom;

    //bad
   public GameObject bad;

    //good
   public GameObject good;

    //cry
   public GameObject cry;

    //Girl_like
    public GameObject girl_like;

    //Girl_sad
    public GameObject girl_sad;



    void Awake(){
        
        boom = transform.Find("PropUI/Boom").gameObject;
        bad = transform.Find("PropUI/bad").gameObject;
        good = transform.Find("PropUI/good").gameObject;
        cry = transform.Find("PropUI/Cry").gameObject;
        girl_like = transform.Find("PropUI/Girl_like").gameObject;
        girl_sad = transform.Find("PropUI/Girl_sad").gameObject;
    }

	//void Start () {
		
	//}
	
	//void Update () {
		
	//}

 
}
