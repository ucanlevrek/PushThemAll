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

    public float percentage;

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
        percentage = (numberoftotal-numberofdeaths) / numberoftotal * 100;
    }
}
