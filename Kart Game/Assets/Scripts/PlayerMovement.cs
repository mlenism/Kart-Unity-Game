using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float positionSpeed = 20f;
    public float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Adds -1 when pressing the "a" key or 1 if it's the "d" 
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Moves the object
        transform.Translate(new Vector3(0.0f, 0.0f, vertical) * Time.deltaTime * positionSpeed);
        transform.Rotate(new Vector3(0.0f, horizontal, 0.0f) * Time.deltaTime * rotationSpeed);
    }
}
