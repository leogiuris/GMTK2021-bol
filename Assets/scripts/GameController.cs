using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }

    //controle camera
    private GameObject c;
    private Vector3 dialogPoint;
    private Vector3 gamePoint;

    //estado do jogo
    public bool dialog = true;
    public static bool isPaused;

    //data
    public Hand playerHand, cpuHand;
    public GameObject player, cpu;
    bool handsHolding;
    int level;
    public int score = 0;
    public static bool canHold;

    //UI
    public GameObject pauseMenu;
    public GameObject dialoguePanel;

    //Utils
    Timer timer;


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


    void StartHandShake()
    {
        player.SetActive(true);
        cpu.SetActive(true);

        timer.StartTimer();
    }

    // Start is called before the first frame update
    void Start()
    {
        //config camera
        c = GameObject.Find("Main Camera");
        gamePoint = c.transform.position;
        dialogPoint = new Vector3(0, 100, 0);
        pauseMenu.SetActive(false);
        level = 0;
        canHold = false;
        timer = new Timer();
        player.SetActive(false);
        cpu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        Gamestate();

        //DEBUG
        Tests();
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
            c.transform.position = dialogPoint;
        }
        else
        {
            c.transform.position = gamePoint;
        }
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();
        if (Input.GetKeyDown(KeyCode.D))
        {
            dialog = false;
            StartHandShake();
            dialoguePanel.SetActive(false);
        }
        
        
    }


    // ---------------- DEBUG -----------------
    void Tests()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Debug.Log(timer.getTime());
    }

}
