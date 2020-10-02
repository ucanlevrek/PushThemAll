using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentCoin;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = currentCoin.ToString();
    }
}
