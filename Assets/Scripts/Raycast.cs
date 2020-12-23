using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private RaycastHit _hit;

    public GameObject hitImage;
    void Update()
    {
        DrawRaycast();
    }
    private void DrawRaycast()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out _hit, 100))
        {
            if (_hit.collider.gameObject.CompareTag("ring"))
            {
                hitImage.SetActive(true);
                hitImage.transform.position = _hit.point;
            }
            else
            {
                hitImage.SetActive(false);
            }
        }
        
        
    }
}
