using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManageUI : MonoBehaviour
{
    EventSystem eventSys;

    //kanvaslar deaktif olduktan sonra find ile bulunamadığı için daha her şey açıkken variable'a alıyor
    GameObject StartCanvas;
    GameObject GameCanvas;
    GameObject FallCanvas;
    GameObject EndCanvas;

    GameObject Player;
    
    public GameObject CointCanvas;

    void Start()
    {
        eventSys = GameObject.Find("EventSystem").GetComponent<EventSystem>();

        //açılması gerekenleri açıp diğerlerini kapatıyor
        StartCanvas = GameObject.Find("LevelStart");
        GameCanvas = GameObject.Find("LevelInGame");
        FallCanvas = GameObject.Find("LevelFall");
        EndCanvas = GameObject.Find("LevelFinish");

        Player = GameObject.Find("Player");

        GameCanvas.SetActive(false);
        FallCanvas.SetActive(false);
        EndCanvas.SetActive(false);
    }

    void Update()
    {
        if (StartCanvas.activeInHierarchy)
        {
            StartToGame();
        }

        if (GameObject.Find("Managers/LevelManager").GetComponent<isIt>().isItFinished)
        {
            GameToEnd();
        }

        if (GameObject.Find("Managers/LevelManager").GetComponent<isIt>().isItDead)
        {
            GameToFall();
        }   
    }

    //LevelinStart'ı kapatıp LevelinGame'ı açıyor
    void StartToGame()
    {
        if (Input.GetMouseButtonDown(0) && !IsPointerOverUIObject())
        {
            StartCanvas.SetActive(false);

            GameCanvas.SetActive(true);
        }
    }

    //LevelinGame'ı kapatıp LevelinFall'ı açıyor
    void GameToFall()
    {
        GameCanvas.SetActive(false);

        FallCanvas.SetActive(true);
    }

    //LevelinGame'ı kapatıp LevelinEnd'ı açıyor
    void GameToEnd()
    {
        GameCanvas.SetActive(false);

        EndCanvas.SetActive(true);
    }

    //Mouse'un bir UI objesinin üstünde olup olmadığını kontrol ediyor
    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        return results.Count > 1;
    }
}
