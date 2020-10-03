using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    public Joystick joystick;

    public float turningSpeed;
    public float constantSpeed;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    Vector3 direction=new Vector3(0,180,0);

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {

        horizontalMove = joystick.Horizontal * constantSpeed;

        verticalMove = joystick.Vertical * constantSpeed;

        direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical).normalized;

        if (Input.GetMouseButton(0) && (joystick.Horizontal!=0 || joystick.Vertical!=0) )
        {
            transform.LookAt(-direction * 360);
        }

        rb.AddForce(new Vector3(-horizontalMove, 0, -verticalMove));
    }
}