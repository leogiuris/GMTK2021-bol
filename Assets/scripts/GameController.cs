using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }

    //controle camera
    public Camera c;
    private Vector3 dialogPoint;
    private Vector3 gamePoint;
    //estado do jogo
    private bool dialog = true;
    public static bool isPaused;

    //data
    public Hand playerHand, cpuHand;
    public Player p;
    bool handsHolding;
    int level;
    public int score = 0;
    public static bool canHold;

    //UI
    public GameObject pauseMenu;


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //config camera
        //camera = GameObject.Find("Main Camera");
        gamePoint = new Vector3(0, 0, 0);
        dialogPoint = new Vector3(0, 100, 0);
        pauseMenu.SetActive(false);
        level = 0;
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
            pauseMenu.SetActive(false);
            //SoundManagerScript.PlaySound("OpenMenu");
        }

        else
        {
            Time.timeScale = 0f;
            isPaused = true;
            pauseMenu.SetActive(true);
            //SoundManagerScript.PlaySound("OpenMenu");
        }
    }

    private void Gamestate()
    {
        if (dialog)
        {
            //camera.transform.position = dialogPoint.position;
        }
        else
        {
            //camera.transform.position = gamePoint.position;
        }
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();
    }
}
