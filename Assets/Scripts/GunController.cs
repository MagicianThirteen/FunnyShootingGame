using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Gun originGun;

    private Gun equipedGun;
    
    public Transform weaponHoldGo;
    // Start is called before the first frame update
    private void Start()
    {
        if (originGun != null)
        {
            EquipGun(originGun);
        }
    }

    public void EquipGun(Gun addGun)
    {
        if(equipedGun!=null) 
            Destroy(equipedGun.gameObject);
        equipedGun = Instantiate(addGun,weaponHoldGo.position,weaponHoldGo.rotation) as Gun;
        equipedGun.transform.parent = weaponHoldGo;
    }

    public void Shoot()
    {
        equipedGun?.Shoot();
    }
}
