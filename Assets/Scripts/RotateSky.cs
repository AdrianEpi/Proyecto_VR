using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    private float rotateSpeed = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("ROTA");
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
