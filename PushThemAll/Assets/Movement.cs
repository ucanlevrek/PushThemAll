using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject handle;
    private Rigidbody rb;

    public float mvspeed;
    public float constantSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(handle.transform.localPosition.x > 0)
        {
            //rb.velocity = 0 * (rb.velocity.normalized);

            rb.AddForce(new Vector3(mvspeed, 0, 0) * Time.deltaTime);

            rb.velocity = constantSpeed * (rb.velocity.normalized);
        }
        else if (handle.transform.localPosition.x < 0)
        {
            //rb.velocity = 0 * (rb.velocity.normalized);

            rb.AddForce(new Vector3(-mvspeed, 0, 0) * Time.deltaTime);

            rb.velocity = constantSpeed * (rb.velocity.normalized);
        }

        if (handle.transform.localPosition.y > 0)
        {
            //rb.velocity = 0 * (rb.velocity.normalized);

            rb.AddForce(new Vector3(0, 0, mvspeed) * Time.deltaTime);

            rb.velocity = constantSpeed * (rb.velocity.normalized);
        }
        else if (handle.transform.localPosition.y < 0)
        {
            //rb.velocity = 0 * (rb.velocity.normalized);

            rb.AddForce(new Vector3(0, 0, -mvspeed) * Time.deltaTime);

            rb.velocity = constantSpeed * (rb.velocity.normalized);
        }
    }
}
