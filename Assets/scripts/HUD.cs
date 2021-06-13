using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    public GameObject scoreBar;
    public List<Sprite> smileys;
    public GameObject knob;
    public List<GameObject> lives;
    private int lifeIndex;


    


    public void updateGotasCounter(int n)
    {
        //gotas.text = ":  " + n + "/" + GameController.Instance.maxGotas;
    }



    // Start is called before the first frame update
    void Start()
    {
        lifeIndex = 0;
    }

    void Update()
    {

        

        scoreBar.GetComponent<Slider>().value = GameController.Instance.awkwardness;

        if (scoreBar.GetComponent<Slider>().value < 1)
            knob.GetComponent<Image>().sprite = smileys[0];
        else if (scoreBar.GetComponent<Slider>().value < 2)
            knob.GetComponent<Image>().sprite = smileys[1];
        else
            knob.GetComponent<Image>().sprite = smileys[2];

        Debug.Log(GameController.Instance.awkwardness);
    }

}