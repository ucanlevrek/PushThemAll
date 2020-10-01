using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobjects : MonoBehaviour
{
    public bool isitdone = false;

    // Start is called before the first frame update
    void Start()
    {
        isitdone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Player")
        {
            isitdone = true;
            Destroy(other.gameObject);
        }
    }
}
