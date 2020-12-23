using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject _plane;
    Vector3 _distance;
    Vector3 _distanceNow;
    public bool _check = false;
    [SerializeField] private GameObject _raycastObject;
    private RaycastHit _hit;
    [SerializeField] private Vector3 _targetRotation;
    private bool _shouldRotate;
    private Vector3 _startRotation;

    void Start()
    {
        _startRotation = transform.localEulerAngles;
        _distance = transform.position - _plane.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DrawRaycast();
        if (_check == false)
        {
            cameraFollowing();
        }

    }
    private void cameraFollowing()
    {

        _distanceNow = transform.position - _plane.transform.position;
        if (_distanceNow != _distance)
        {
            Vector3 _difference = _distance - _distanceNow;
            transform.position = Vector3.Lerp(transform.position, transform.position + _difference, 0.1f);
        }


    }

    void DrawRaycast()
    {
        if (Physics.Raycast(_raycastObject.transform.position, _raycastObject.transform.TransformDirection(Vector3.forward), out _hit, 10000))
        {
            Debug.Log(_hit.collider.gameObject.name);
            Debug.DrawLine(_raycastObject.transform.position, _hit.point, Color.black);
            if (_hit.collider.gameObject.tag == "stay" || _hit.collider.gameObject.tag == "PassRing" || _hit.collider.gameObject.tag == "ring")
            {
                transform.DORotate(_startRotation, 2f);
            }
            else if (_hit.collider.gameObject.tag == "rotate")
            {
                transform.DORotate(_targetRotation, 2f);
            }
        }
    }


}