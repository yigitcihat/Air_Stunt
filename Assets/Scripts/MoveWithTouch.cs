using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Michsky.UI.ModernUIPack;
using TMPro;
using Utils.UI;

public class MoveWithTouch : MonoBehaviour
{

    [SerializeField] private GameObject _plane;
    public Rigidbody _planeRigid;
    public float speed;
    public float rotationSpeed;
    public Joystick _joyStick;
    public float joyStickVertical;
    public ProgressBar _progressBar;
    [SerializeField] ParticleSystem fallingParticle;

    private void Update()
    {
        FuelControl();
        transform.Rotate(_joyStick.Vertical * rotationSpeed * Time.deltaTime, 0, 0);
        

        if (Input.touchCount > 0)
        {
            foreach (var touch in Input.touches)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        break;
                    case TouchPhase.Moved:
                        break;
                    case TouchPhase.Stationary:
                        break;
                    case TouchPhase.Ended:
                        break;
                    case TouchPhase.Canceled:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                
            }
        }
    }

    private void FixedUpdate()
    {
        _planeRigid.velocity = _plane.transform.forward * speed * Time.deltaTime;
    }

    private void FuelControl()
    {
        if (_progressBar.currentPercent <= 0)
        {

            Debug.Log("Fuel Bitti!");

            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.GetComponent<MoveWithTouch>().enabled = false;
            fallingParticle.Play();

        }
    }



    //Diğer Mekanik denemesi - Titreşiyor
    #region MyRegion
    //Rigidbody _flyRigid;

    //[SerializeField] GameObject _camera;
    //[SerializeField] float _timeRotation;
    //public float _speedModifier;
    //[SerializeField] float _cameraMovementDistance;

    //public Joystick joystick;

    //public CharacterController controllerPlayer;
    //public float speed = 20f;

    //public bool _isTouched = false;

    //


    //void Start()
    //{
    //    Time.timeScale = 1;


    //    _flyRigid = GetComponent<Rigidbody>();



    //}
    //void Update()
    //{
    //    flyMovement();
    //    flyRotation();

    //}


    //private void flyMovement()
    //{
    //    transform.position += transform.forward * Time.deltaTime * speed * 4f;

    //}
    //private void flyRotation()
    //{
    //    float forwardMove = joystick.Vertical;
    //    float forwardRightLeft= joystick.Horizontal;
    //    if (forwardMove > 0)
    //    {

    //        transform.Translate(transform.forward * forwardMove * Time.deltaTime * 2, Space.World);
    //        transform.Rotate(transform.right, 50.0f * Time.deltaTime * forwardMove, Space.World);

    //    }
    //    else if (forwardMove < 0)
    //    {
    //        transform.Translate(transform.forward * forwardMove * Time.deltaTime * 2, Space.World);
    //        transform.Rotate(transform.right, 50.0f * Time.deltaTime * forwardMove, Space.World);
    //    }

    //    if (forwardRightLeft > 0 )
    //    {
    //        transform.Rotate(0, 0, forwardRightLeft * Time.deltaTime * -50f);

    //        //Sağa sola dönebilmesi için
    //        //transform.Rotate(transform.up, -10.0f * Time.deltaTime * forwardRightLeft, Space.World);



    //    }
    //    else if(forwardRightLeft < 0)
    //    {
    //        transform.Rotate(0, 0, forwardRightLeft * Time.deltaTime * -50f);

    //        //Sağa sola dönebilmesi için
    //        //transform.Rotate(transform.up, -10.0f * Time.deltaTime * forwardRightLeft, Space.World);
    //    }



    //}

    #endregion

}
