using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFallScript2 : MonoBehaviour
{
    public Text totalCoin;
    void Start()
    {
        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
    }
    public void Retry()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel")-1);
    }
}
