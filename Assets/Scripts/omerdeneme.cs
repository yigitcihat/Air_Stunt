using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omerdeneme : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    public Rigidbody _planeRigid;
    public float speed;
    public float rotationSpeed;
    public Joystick _joyStick;
    public float joyStickVertical;

    private void Update()
    {
        transform.Rotate(_joyStick.Vertical*rotationSpeed*Time.deltaTime,0,0);
        
    }

    private void FixedUpdate()
    {
        _planeRigid.velocity = _plane.transform.forward * speed * Time.deltaTime;
    }
}
