using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCrushController : MonoBehaviour
{
    [SerializeField] GameObject particle;
    [SerializeField] ParticleSystem _fallingParticle;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            Instantiate(particle ,other.transform.position ,Quaternion.identity); 
            Destroy(other.gameObject);
            _fallingParticle.Stop();

        }
        

    }

}
