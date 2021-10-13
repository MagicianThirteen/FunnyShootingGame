using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //行为只有一个：一出生就往前飞
    //属性只有一个：速度（不过每种子弹估计速度不一样，所以还要有设置速度的方法）
    public float Speed = 10;
    public LayerMask collisionMask;

    public void SetSpeed(float velocitySpeed)
    {
        this.Speed = velocitySpeed;
    }
    void Update()
    {
        //根据方向和移动距离
        float moveDistance = Speed * Time.deltaTime;
        CheckCollision(moveDistance);
        transform.Translate(Vector3.forward*moveDistance);
        
    }

    void CheckCollision(float distance)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,distance, collisionMask, QueryTriggerInteraction.Collide))
        {
            HitDoing(hit);
        }
    }

    void HitDoing(RaycastHit hit)
    {
        Debug.Log("当前打到的是："+hit.collider.gameObject.name);
        Destroy(gameObject);
    }
}
