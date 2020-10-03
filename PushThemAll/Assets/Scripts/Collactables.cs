using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collactables : MonoBehaviour
{
    //istediğin variable'a erişmen için her şeyi managerlara atan bir kod

    public int CurrentCoin=10;

    public int Score = 200;

    public int TotalCoin = 0;

    private void Update()
    {
        TotalCoin = PlayerPrefs.GetInt("TotalCoin");    
    }
}
