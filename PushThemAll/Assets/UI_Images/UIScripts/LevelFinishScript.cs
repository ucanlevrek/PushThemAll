using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFinishScript : MonoBehaviour
{
    private int yuzde = 100;
    private int yuzdeee = 100;
    private int puan = 2500;
    private int collectedCoin = 12;


    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public Slider slider;

    public Text yuzdee;
    public Text puann;
    public Text collected;


    private bool yuzdeCompleted = false;
    private bool puanCompleted = false;

    public int a = 0;
    private int b = 0;
    private int c = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

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
}
