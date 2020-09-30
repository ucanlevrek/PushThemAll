using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement_basicscript : MonoBehaviour
{
    GameObject player;
    private Vector3 offset;

    bool noplayer = false;
  
    
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null && noplayer == false)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            offset = transform.position - player.transform.position;
            noplayer = true;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        {
            gameObject.transform.position = player.transform.position + offset;
        }
    }
}
