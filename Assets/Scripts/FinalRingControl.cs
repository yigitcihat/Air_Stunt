using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRingControl : MonoBehaviour
{
    public GameObject[] gameObjects;
    [SerializeField] GameObject particle;
    public int ringNum;
    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (gameObjects[i].GetComponent<Renderer>().material.color == Color.green)
            {
                ringNum--;
            }
            else
            {
                return;
            }

            
        }
        if (ringNum == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            Instantiate(particle, gameObject.transform.position, Quaternion.identity);

        }

    }
}
