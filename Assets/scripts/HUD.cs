using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    public GameController controller;
    public GameObject scoreBar;
    public List<Sprite> smileys;
    public GameObject knob;
    public List<GameObject> lives;
    public int lifeIndex;
    public int maxLife;

    


    



    // Start is called before the first frame update
    void Start()
    {

        maxLife = controller.lives;
        
    }

    void Update()
    {
        lifeIndex = maxLife - controller.lives;

        for(int i = 0; i < lifeIndex; i++)
        {
            Debug.Log("desenho vida");
            lives[lifeIndex - 1].SetActive(true);
        }

        scoreBar.GetComponent<Slider>().value = GameController.Instance.awkwardness;

        if (scoreBar.GetComponent<Slider>().value < 1)
            knob.GetComponent<Image>().sprite = smileys[0];
        else if (scoreBar.GetComponent<Slider>().value < 2)
            knob.GetComponent<Image>().sprite = smileys[1];
        else
            knob.GetComponent<Image>().sprite = smileys[2];

        //Debug.Log(GameController.Instance.awkwardness);
    }

}