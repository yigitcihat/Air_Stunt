using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashControl : MonoBehaviour
{

    [SerializeField] GameObject particle;
    [SerializeField] private ParticleSystem _fallingParticle;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ring")
        {
            Debug.Log("Uçak çarptı");
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            gameObject.GetComponent<MoveWithTouch>().enabled = false;
            Instantiate(particle, gameObject.transform.position, Quaternion.identity);
            _fallingParticle.Play();
        }
    
    }
}
