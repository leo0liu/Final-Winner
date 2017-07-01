using UnityEngine;
using System.Collections;

public class ChoiseMgr : MonoBehaviour {

    //第二摄像机
    GameObject cameraTwo;
    Camera cameraTwoCa;
    //主摄像击
    Camera mainCamera;

    //移动主体
   public GameObject choisePosition;

    private Vector3 target;//目标位置
    private bool isOver = true;//移动是否结束
    public int speed=40;//移动的速度

    //记录一个主罚点的位置,作为原始点重新踢的起始点
   public  Vector3 orginPoint;

    public void Inst()
    {
        cameraTwo = GameObject.FindWithTag("CameraTwo");
        cameraTwoCa = cameraTwo.GetComponent<Camera>();
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        choisePosition = GameObject.FindWithTag("ChoisePositon");
    }


	void Start () {
        Inst();
    }

    void Update()
    {
        if (Global._instance.uiMgr.settingView.isSettingView) {
            if (Input.GetMouseButtonDown(0))
            {
                //1.获取鼠标点击时的目标位置/目标点
                //使用射线实现,创建射线
                // 从摄像机发射一条经过鼠标当前位置的射线
                Ray ray = cameraTwoCa.ScreenPointToRay(Input.mousePosition);
                // 发射一条射线
                RaycastHit hitInfo = new RaycastHit();
                if (Physics.Raycast(ray, out hitInfo))
                {
                    //获取碰撞点的位置
                    if (hitInfo.collider.name == "Stadium")
                    {
                        target = hitInfo.point;
                        orginPoint=target;
                        isOver = false;
                    }
                }
            }
        }
        //2.让角色移动到目标位置
        MoveTo(target);
    }

    //让角色移动到目标位置
     public  void MoveTo(Vector3 tar)
     {
        if (!isOver)
        {
            if ((tar.x<-12)&&(tar.x>-38&&(tar.z>-35)&&(tar.z<35))) {
                Vector3 v1 = tar - choisePosition.transform.position;

                choisePosition.transform.position += v1.normalized * speed * Time.deltaTime;
                if (Vector3.Distance(tar, choisePosition.transform.position) <= 0.5f)
                {
                    isOver = true;
                    choisePosition.transform.position = tar;

                }
            }
        }
   }
}
