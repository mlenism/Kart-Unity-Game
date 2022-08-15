using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Vector3 velocity = Vector3.zero;
    private bool changeView = false;
    private float smoothLevel = 0.125f;
    private float cameraPositionY = 1.5f;
    private int carDistance = 4;
    // Update is called once per frame
    void Update()
    {
        Vector3 jeepPosition = GameObject.Find("Jeep_Renegade_2016").transform.position;
        Vector3 jeepPositionFixed = new Vector3(jeepPosition.x,jeepPosition.y + cameraPositionY, jeepPosition.z + carDistance);
        Vector3 newPosition = new Vector3(jeepPosition.x,jeepPosition.y + cameraPositionY, jeepPosition.z - carDistance);

        if (Input.GetKeyDown(KeyCode.P))
        {
            changeView = !changeView;
            if (!changeView)
            {
                transform.position = jeepPositionFixed;
                transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
            } else {
                transform.position = newPosition;
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            }
        } else {
            if (!changeView)
            {
                transform.position = Vector3.SmoothDamp(transform.position, jeepPositionFixed, ref velocity, smoothLevel);
            } else {
                transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothLevel);
            }
        }



    }
}
