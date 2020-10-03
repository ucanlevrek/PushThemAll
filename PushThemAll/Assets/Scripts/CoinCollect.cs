using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public GameObject GameCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameCanvas.GetComponent<CoinCounter>().currentCoin++;

            PlayerPrefs.SetInt("TotalCoin", PlayerPrefs.GetInt("TotalCoin")+1); //Oyun bitince topladığımız altınları totale ekliyor

            GameObject.Find("Managers/LevelManager").GetComponent<Collactables>().CurrentCoin = GameCanvas.GetComponent<CoinCounter>().currentCoin;

            GameObject.Destroy(gameObject);
        }
    }
}
