using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour,IDamageable
{
    //属性 hp
    public int startHp=10;

    public int currHp=0;
    //状态：死亡
    protected bool isDead = false;

    protected virtual void Start()
    {
        currHp = startHp;
    }

    //行为：处理扣血
    public void TakeHit(float damage, RaycastHit hitInfo)
    {
        currHp -=(int)damage;
        if (currHp <= 0&&!isDead)
        {
            isDead = true;
            Die();
        }
    }
    //行为：死亡行为
    public void Die()
    {
        if (isDead)
        {
            Destroy(gameObject);
        }
    }
    
}
