using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInGameScript : MonoBehaviour
{
    public GameObject backToMenu;

    public void HomeButton()
    {
        backToMenu.SetActive(true);
    }
}
