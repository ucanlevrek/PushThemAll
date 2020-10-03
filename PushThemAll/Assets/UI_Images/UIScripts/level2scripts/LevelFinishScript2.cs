using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelFinishScript2 : MonoBehaviour
{
    private int yuzde;
    private int yuzdeee;
    private int puan;
    private int collectedCoin = 12;


    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public Slider slider;

    public Text yuzdee;
    public Text puann;
    public Text collected;
    public Text totalCoin;

    private int a = 0;
    private int b = 0;
    private int c = 0;

    void Start()
    {
        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
        yuzde = GameObject.Find("Managers/LevelManager").GetComponent<enemyCounter>().percentage;
        yuzdeee = GameObject.Find("Managers/LevelManager").GetComponent<enemyCounter>().percentage;
        puan = GameObject.Find("Managers/LevelManager").GetComponent<Collactables>().Score;
        collectedCoin = GameObject.Find("Managers/LevelManager").GetComponent<Collactables>().CurrentCoin;
        yuzdee.text = a.ToString();
        puann.text = b.ToString();
        collected.text = c.ToString();
    }
    void Update()
    {
        totalCoin.text = PlayerPrefs.GetInt("TotalCoin").ToString();
        yuzde = GameObject.Find("Managers/LevelManager").GetComponent<enemyCounter>().percentage;
        yuzdeee = GameObject.Find("Managers/LevelManager").GetComponent<enemyCounter>().percentage;
        puan = GameObject.Find("Managers/LevelManager").GetComponent<Collactables>().Score;

        if (yuzde > 0)
        {
            slider.value++;
            yuzde--;
            if (slider.value >= 10)
                star1.SetActive(true);
            if (slider.value >= 50)
                star2.SetActive(true);
            if (slider.value >= 90)
                star3.SetActive(true);
        }
        if (a <= yuzdeee)
        {
            yuzdee.text = a.ToString() + "%";
            a+=2;
        }
        
        if (b <= puan && a>=yuzdeee)
        {
            puann.text = b.ToString();
            b+=10;
        }
        if (b>=puan && c<=collectedCoin)
        {
            collected.text = "+" + c.ToString();
            c++;
        }
    }

    public void Continue()
    {
        int level = PlayerPrefs.GetInt("CurrentLevel");
        level++;
        PlayerPrefs.SetInt("CurrentLevel", level);
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel") - 1);
    }
}
