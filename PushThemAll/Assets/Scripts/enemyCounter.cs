using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCounter : MonoBehaviour
{
    GameObject[] totalenemies;
    GameObject[] currentenemies;

    public float numberoftotal;
    public float numberofcurrent;

    public float percentage;

    // Start is called before the first frame update
    void Start()
    {
        totalenemies = GameObject.FindGameObjectsWithTag("Enemy");
        numberoftotal = totalenemies.Length;
    }

    // Update is called once per frame
    void Update()
    {
        currentenemies = GameObject.FindGameObjectsWithTag("Enemy");
        numberofcurrent = currentenemies.Length;

        percentage = numberofcurrent / numberoftotal * 100;
    }
}
