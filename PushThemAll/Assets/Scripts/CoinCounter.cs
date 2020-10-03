using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentCoin;

    void Start()
    {
        gameObject.GetComponent<Text>().text = "0";
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = currentCoin.ToString();
    }
}
