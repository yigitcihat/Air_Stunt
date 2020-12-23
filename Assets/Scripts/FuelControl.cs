using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FuelControl : MonoBehaviour
{
    int time = 100;
    public Text textMesh;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1;
        textMesh.text = time + "%";

    }
}
