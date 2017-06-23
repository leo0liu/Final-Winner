using UnityEngine;
using System.Collections;

public class GoalKeeperAnimation : MonoBehaviour {

    //守门员动画系统类
  public  Animation GoalKeeperAnima;


    void Awake()
    {
        GoalKeeperAnima = GetComponent <Animation>();
    }

    //中间部位轻松拿到球
    public  void MiddleGetBall()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_get_ball_front");
        GoalKeeperAnima.CrossFade("goalkeeper_catch_ball");
    }
    //左上接球
   public  void leftUpPickUpBall()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_left_up");
    }

    //左上挡球
   public  void leftUpBlockBall()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_left_up");
    }
    
    //右上接球
   public  void RightUpPickUp()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_right_up");
    }

    //右上挡球
   public void RightUpBlock()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_right_up");
    }

    //左下接球
   public void leftDownPickUpBall()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_left_down");
    }

    //左下挡球
   public void leftDownBlockBall()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_left_down");
    }

    //右下接球
  public  void RightDownPickUp()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_right_down");
    }

    //右下挡球
   public void RightDownBlock()
    {
        GoalKeeperAnima.CrossFade("goalkeeper_clear_right_down");
    }

    //结束接球,回到自然状态
    void ReturnRest()
    {

    }

}
