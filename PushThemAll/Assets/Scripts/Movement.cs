using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject handle;
    private Rigidbody rb;

    public float mvspeed;
    public float constantSpeed1, constantSpeed2, constantSpeed3;
    private float constantSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (handle.transform.localPosition.x > 0)
        {
            if (handle.transform.localPosition.magnitude < 32)
            {
                constantSpeed = constantSpeed1;
            }
            else if (handle.transform.localPosition.magnitude < 64)
            {
                constantSpeed = constantSpeed2;
            }
            else
            {
                constantSpeed = constantSpeed3;
            }

            rb.AddForce(new Vector3(-mvspeed, 0, 0) * Time.deltaTime);

            if (rb.velocity.magnitude > constantSpeed)
            {
                rb.velocity = constantSpeed * (rb.velocity.normalized);
            }
        }

        if (handle.transform.localPosition.x < 0)
        {
            if (handle.transform.localPosition.magnitude < 32)
            {
                constantSpeed = constantSpeed1;
            }
            else if (handle.transform.localPosition.magnitude < 64)
            {
                constantSpeed = constantSpeed2;
            }
            else
            {
                constantSpeed = constantSpeed3;
            }

            rb.AddForce(new Vector3(mvspeed, 0, 0) * Time.deltaTime);

            if (rb.velocity.magnitude > constantSpeed)
            {
                rb.velocity = constantSpeed * (rb.velocity.normalized);
            }
        }

        if (handle.transform.localPosition.y > 0)
        {
            if (handle.transform.localPosition.magnitude < 32)
            {
                constantSpeed = constantSpeed1;
            }
            else if (handle.transform.localPosition.magnitude < 64)
            {
                constantSpeed = constantSpeed2;
            }
            else
            {
                constantSpeed = constantSpeed3;
            }

            rb.AddForce(new Vector3(0, 0, -mvspeed) * Time.deltaTime);

            if (rb.velocity.magnitude > constantSpeed)
            {
                rb.velocity = constantSpeed * (rb.velocity.normalized);
            }
        }

        if (handle.transform.localPosition.y < 0)
        {
            if (handle.transform.localPosition.magnitude < 32)
            {
                constantSpeed = constantSpeed1;
            }
            else if (handle.transform.localPosition.magnitude < 64)
            {
                constantSpeed = constantSpeed2;
            }
            else
            {
                constantSpeed = constantSpeed3;
            }

            rb.AddForce(new Vector3(0, 0, mvspeed) * Time.deltaTime);

            if (rb.velocity.magnitude > constantSpeed)
            {
                rb.velocity = constantSpeed * (rb.velocity.normalized);
            }
        }
    }
}