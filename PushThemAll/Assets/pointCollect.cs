using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollect : MonoBehaviour
{
    public GameObject GameCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameCanvas.GetComponent<CoinCounter>().currentCoin++;

            GameObject.Destroy(gameObject);
        }
    }
}
