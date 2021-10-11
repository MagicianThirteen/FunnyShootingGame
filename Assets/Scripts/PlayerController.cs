using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Vector3 _moveVelocity;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 velocity)
    {
        _moveVelocity = velocity;
    }

    public void LookAt(Vector3 point)
    {
        Vector3 trulyPoint = new Vector3(point.x, transform.position.y, point.z);
        transform.LookAt(trulyPoint);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
       _rigidbody.MovePosition(_rigidbody.position+_moveVelocity*Time.fixedDeltaTime);
       
    }
}
