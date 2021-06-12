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
    public static bool isPaused;

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

    public void Pause()
    {
        Debug.Log("pause");
        if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
            //pauseMenu.SetActive(false);
            //SoundManagerScript.PlaySound("OpenMenu");
        }

        else
        {
            Time.timeScale = 0f;
            isPaused = true;
            //pauseMenu.SetActive(true);
            //SoundManagerScript.PlaySound("OpenMenu");
        }
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
        if (Input.GetKeyDown(KeyCode.Tab)) Pause();
    }
}
