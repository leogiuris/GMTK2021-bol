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
    private int maxLife;

    


    



    // Start is called before the first frame update
    void Start()
    {

        maxLife = GameController.Instance.lives;
        
    }

    void Update()
    {
        lifeIndex = maxLife - GameController.Instance.lives;

        for(int i = 0; i < lifeIndex; i++)
        {
            lives[lifeIndex - 1].SetActive(true);
        }

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