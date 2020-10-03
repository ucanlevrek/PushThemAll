using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuScript2 : MonoBehaviour
{
    public GameObject backToMenu;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void No()
    {
        Time.timeScale = 1;
        backToMenu.SetActive(false);
    }

    public void Yes()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel")-1);
    }
}
