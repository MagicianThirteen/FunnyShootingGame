using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //行为只有一个：一出生就往前飞
    //属性只有一个：速度（不过每种子弹估计速度不一样，所以还要有设置速度的方法）
    public float Speed = 10;

    public void SetSpeed(float velocitySpeed)
    {
        this.Speed = velocitySpeed;
    }
    void Update()
    {
        //根据方向和移动距离
        transform.Translate(Vector3.forward*Speed*Time.deltaTime);
    }
}
