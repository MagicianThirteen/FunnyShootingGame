using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    private int moveSpeed = 5;

    private PlayerController _controller;
    private GunController _gunController;

    private Camera viewCamera;
    void Start()
    {
        _controller = GetComponent<PlayerController>();
        _gunController = GetComponent<GunController>();
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //MoveInput
        Vector3 moveVelocit = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 _moveVelocit = moveVelocit.normalized*moveSpeed;
        _controller.Move(_moveVelocit);

        //RotateInput
        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        float rayDistance;
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        if (plane.Raycast(ray,out rayDistance))//如果射线和面板有相交
        {
            //得到相交得点
            Vector3 point = ray.GetPoint(rayDistance);
            //通过相交的点和射线原点，画旋转的范围
            //Debug.DrawLine(ray.origin,point,Color.red);
            _controller.LookAt(point);
        }
        
        //ShootInput
        if (Input.GetMouseButton(0))
        {
           _gunController.Shoot();
        }

    }
}
