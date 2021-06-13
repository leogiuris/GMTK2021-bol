using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GameController : MonoBehaviour
{

    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }

    //controle camera
    private GameObject c;
    private Vector3 dialogPoint;
    private Vector3 gamePoint;
    private Vector3 reactionPoint;

    //estado do jogo
    public bool dialogue = true;
    public static bool isPaused = false;

    //data
    public NPC npc;
    public Hand playerHand, cpuHand;
    public GameObject player, cpu;
    private Transform t_player, t_cpu;
    bool handsHolding;

    public int score = 0;
    public static bool canHold;

    //awkwardness meter
    public GameObject meter;
    public float awkwardness = 0;
    public float awkwardMod = 1;
    public float maxHangtime = 0.5f;
    public float hangtime = 0.5f;
    public float handsOn = 0;
    private int reactionInt = 0;//0 = win, 1 = lose;

    //timer
    private float countDown = -1f;
    private float reactionTime = 3;
    private bool running = false;


    //UI
    public UI_Manager ui;





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
        c = GameObject.Find("Main Camera");
        gamePoint = c.transform.position;
        dialogPoint = new Vector3(0, 100, 0);
        reactionPoint = new Vector3(0, 300, 0);
        canHold = false;
        t_player = player.transform;
        t_cpu = cpu.transform;
        player.SetActive(false);
        cpu.SetActive(false);

        ShowDialogue();

    }





    public void ShowDialogue()
    {
        dialogue = true;
        ui.dialoguePanel.SetActive(true);
        c.transform.position = dialogPoint;

    }

    void StartHandShake()
    {
        player.SetActive(true);
        cpu.SetActive(true);

        player.GetComponent<Hand>().Reset();
        cpu.GetComponent<Hand>().Reset();



        c.transform.position = gamePoint;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        Gamestate();
        AwkwardControl();
        Timer();
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
            ui.pauseMenu.SetActive(false);
            Cursor.visible = false;
            //SoundManagerScript.PlaySound("OpenMenu");
        }

        else
        {
            Time.timeScale = 0f;
            isPaused = true;
            ui.pauseMenu.SetActive(true);

        }
    }
    public void Reaction()
    {
        c.transform.position = reactionPoint;
        npc.reFace.sprite = npc.reFaces[reactionInt];
        countDown = reactionTime;
        running = true;
    }

    private void Timer()
    {
        if (running)
        {
            if (countDown >= 0)
            {
                countDown -= Time.deltaTime;
            }
            else
            {
                running = false;
                ShowDialogue();
                npc.ChangeNpc();
            }
        }
    }

    public void Win()
    {
        hangtime = maxHangtime;
        handsOn = 0;
        player.SetActive(false);
        cpu.SetActive(false);
        reactionInt = 0;
        Reaction();
    }
    public void Lose()
    {
        hangtime = maxHangtime;
        handsOn = 0;
        player.SetActive(false);
        cpu.SetActive(false);
        reactionInt = 1;
        Reaction();

    }

    private void Gamestate()
    {
        if (dialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dialogue = false;
                ui.dialoguePanel.SetActive(false);
                StartHandShake();
            }
        }
        if (isPaused)
        {
            // coisas p fazer no menu de pause
        }
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();
        
    }

    private void AwkwardControl()
    {
        if(!dialogue && handsOn >0)
        {
            hangtime -= (awkwardMod / handsOn) * Time.deltaTime;
            if (hangtime <= 0)
            {
                Debug.Log("hanging");
                awkwardness += (awkwardMod / handsOn) * Time.deltaTime;
            }

        }
    }


    // ---------------- DEBUG -----------------
    void Tests()
    {

    }

}
