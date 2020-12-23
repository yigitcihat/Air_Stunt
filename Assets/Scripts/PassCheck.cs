using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCheck : MonoBehaviour
{
    [SerializeField] GameObject particle;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" )
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            Instantiate(particle, gameObject.transform.position, Quaternion.identity);
        }
    }
}
