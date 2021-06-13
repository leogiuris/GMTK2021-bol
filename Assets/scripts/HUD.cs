using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    public GameObject scoreBar;

    

    public void updateGotasCounter(int n)
    {
        //gotas.text = ":  " + n + "/" + GameController.Instance.maxGotas;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        scoreBar.GetComponent<Slider>().value = GameController.Instance.awkwardness;
        Debug.Log(GameController.Instance.awkwardness);
    }

}