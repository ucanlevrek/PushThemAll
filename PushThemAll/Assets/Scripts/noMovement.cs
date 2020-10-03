using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noMovement : MonoBehaviour
{
    private float holdy;

    public bool isFinished=false;
    public bool isitdone = false;

    void Start()
    {
        holdy = transform.position.y;
    }

    void Update()
    {
        //Düşünce dursun diye
        if(transform.position.y < (holdy - 0.2f))
        {
            gameObject.GetComponent<Movement>().enabled = false;

            isitdone = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Oyun bitti mi
        if(other.gameObject.tag == "FinalCollider")
        {
            gameObject.GetComponent<Movement>().enabled = false;

            GameObject.Find("Managers/LevelManager").GetComponent<isIt>().isItFinished = true;
        }
    }
}
