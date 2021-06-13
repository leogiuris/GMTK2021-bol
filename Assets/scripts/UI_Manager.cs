using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject dialoguePanel;
    public GameObject pauseMenu;
    public GameObject HUD;
    
    public void Resume()
    {
        GameController.Instance.Pause();
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
