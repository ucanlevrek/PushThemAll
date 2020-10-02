using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuScript : MonoBehaviour
{
    public GameObject backToMenu;
    public void No()
    {
        backToMenu.SetActive(false);
    }

    public void Yes()
    {
        SceneManager.LoadScene(1);
    }
}
