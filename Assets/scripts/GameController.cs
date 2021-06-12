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
    public bool dialogue = true;
    public static bool isPaused;

    //data
    public Hand playerHand, cpuHand;
    public GameObject player, cpu;
    private Transform t_player, t_cpu;
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

    public void ShowDialogue()
    {
        dialogue = true;
        dialoguePanel.SetActive(true);
        c.transform.position = dialogPoint;
        
    }

    void StartHandShake()
    {
        player.SetActive(true);
        cpu.SetActive(true);

        player.GetComponent<Hand>().Reset();
        cpu.GetComponent<Hand>().Reset();

        player.transform.position = t_player.position;
        cpu.transform.position = t_cpu.position;
        
        c.transform.position = gamePoint;
        Cursor.visible = false;
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
        t_player = player.transform;
        t_cpu = cpu.transform;
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
            Cursor.visible = false;
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

    public void Win()
    {
        ShowDialogue();
    }
    public void Lose()
    {
        ShowDialogue();
    }

    private void Gamestate()
    {
        if (dialogue)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                dialogue = false;
                dialoguePanel.SetActive(false);
                StartHandShake();
            }
        }
        if (isPaused)
        {
            // coisas p fazer no menu de pause
        }
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();
        
    }


    // ---------------- DEBUG -----------------
    void Tests()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Debug.Log(timer.getTime());
    }

}
