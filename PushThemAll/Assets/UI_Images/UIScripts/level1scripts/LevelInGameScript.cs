using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelInGameScript : MonoBehaviour
{
    public GameObject backToMenu;
    public Text totalCoin;
    public Text score;
    private int temp;

    void Start()
    {
        Debug.Log("in");
        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
        score.text = "0";
    }

    void Update()
    {
        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
        temp = GameObject.Find("Managers/LevelManager").GetComponent<Collactables>().Score;
        score.text = temp.ToString();
    }

    public void HomeButton()
    {
        backToMenu.SetActive(true);
    }
}
