using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCounter : MonoBehaviour
{
    GameObject[] totalenemies;
    GameObject[] currentenemies;

    public float numberoftotal;
    public float numberofcurrent;
    public float numberofdeaths;

    public int percentage;

    void Start()
    {
        totalenemies = GameObject.FindGameObjectsWithTag("Enemy");
        numberoftotal = totalenemies.Length;
    }

    void Update()
    {
        currentenemies = GameObject.FindGameObjectsWithTag("Enemy");
        numberofcurrent = currentenemies.Length;

        //Şimdilik biraz farklı çalışıyor ama oyun bitince BottomColliderın bir parçasını ayırsak yeterli
        percentage = Convert.ToInt32((numberoftotal-numberofdeaths) / numberoftotal) * 100;
    }
}
