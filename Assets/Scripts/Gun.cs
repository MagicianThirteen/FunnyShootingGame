using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Gun : MonoBehaviour
{ 
    public Transform muzzle;
    public  Projectile _projectile;
    public float msBetweenShots = 100;
    public float muzzleVelocity = 35;
    private float shootTime;
    public void Shoot()
    {
        if (Time.time > shootTime)
        {
            shootTime = Time.time + msBetweenShots / 1000;
            Projectile newProjectile = Instantiate(_projectile, muzzle.transform.position, muzzle.transform.rotation);
            newProjectile.SetSpeed(muzzleVelocity);
        }
        
    }
}
