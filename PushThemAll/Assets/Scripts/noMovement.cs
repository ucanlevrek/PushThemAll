using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noMovement : MonoBehaviour
{
    private float holdy;

    // Start is called before the first frame update
    void Start()
    {
        holdy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < (holdy - 0.2f))
        {
            gameObject.GetComponent<Movement>().enabled = false;
        }
    }
}
