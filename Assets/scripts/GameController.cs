using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //controle camera
    private GameObject camera;
    private Transform dialogPoint;
    private Transform gamePoint;
    //estado do jogo
    private bool dialog = true;

    //data
    public Hand playerHand, cpuHand;
    public Player p;
    bool handsHolding;
    public int score = 0;
    public static bool canHold;

    // Start is called before the first frame update
    void Start()
    {
        //config camera
        camera = GameObject.Find("Main Camera");
        gamePoint.position = new Vector3(0, 0, 0);
        gamePoint.position = new Vector3(0, 100, 0);

        canHold = false;
    }

    // Update is called once per frame
    void Update()
    {
        Gamestate();


    }
    
    private void Gamestate()
    {
        if (dialog)
        {
            camera.transform.position = dialogPoint.position;
        }
        else
        {
            camera.transform.position = gamePoint.position;
        }
    }
}
