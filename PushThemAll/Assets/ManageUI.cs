using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManageUI : MonoBehaviour
{
    EventSystem eventSys;

    GameObject StartCanvas;
    GameObject GameCanvas;
    GameObject FallCanvas;
    GameObject EndCanvas;

    GameObject Player;
    
    public GameObject CointCanvas;
    // Start is called before the first frame update
    void Start()
    {
        eventSys = GameObject.Find("EventSystem").GetComponent<EventSystem>();

        StartCanvas = GameObject.Find("LevelStart");
        GameCanvas = GameObject.Find("LevelInGame");
        FallCanvas = GameObject.Find("LevelFall");
        EndCanvas = GameObject.Find("LevelFinish");

        Player = GameObject.Find("Player");

        GameCanvas.SetActive(false);
        FallCanvas.SetActive(false);
        EndCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (StartCanvas.activeInHierarchy)
        {
            StartToGame();
        }

        if (Player.activeInHierarchy)
        {
            if (Player.GetComponent<noMovement>().isFinished)
            {
                GameToEnd();
            }

            if (Player.GetComponent<noMovement>().isitdone)
            {
                GameToFall();
            }
        }   
    }

    void StartToGame()
    {
        if (Input.GetMouseButtonUp(0) && eventSys.IsPointerOverGameObject())
        {
            StartCanvas.SetActive(false);

            GameCanvas.SetActive(true);
        }
    }

    void GameToFall()
    {
        GameCanvas.SetActive(false);

        FallCanvas.SetActive(true);
    }

    void GameToEnd()
    {            
        GameCanvas.SetActive(false);

        EndCanvas.SetActive(true);
    }
}
