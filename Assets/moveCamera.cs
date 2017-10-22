using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{

    // Use this for initialization
    public float speed = 10.0F;
    public float rotationSpeed = 10.0F;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float MYRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float MXRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        MYRotation *= Time.deltaTime;
        MXRotation *= Time.deltaTime;
        transform.Translate(rotation, 0, translation);
        transform.Rotate(-MXRotation, MYRotation, 0);
 
    }
}
