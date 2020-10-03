using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobjects : MonoBehaviour
{
    public bool isitdone = false;

    void Start()
    {
        isitdone = false;
    }

    //üstüne düşeni öldürüyor eğer enemy ise numberofdeathi 1 artırıyor
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            GameObject.Find("Managers/LevelManager").GetComponent<enemyCounter>().numberofdeaths++;

            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Player")
        {
            GameObject.Find("Managers/LevelManager").GetComponent<isIt>().isItDead = true;

            Destroy(other.gameObject);
        }
    }
}
