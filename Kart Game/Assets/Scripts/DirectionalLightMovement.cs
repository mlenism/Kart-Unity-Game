using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLightMovement : MonoBehaviour
{

    public float rotationSpeedX = 0f;
    public float rotationSpeedY = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotationSpeedX, rotationSpeedY, 0.0f) * Time.deltaTime); 
    }
}
