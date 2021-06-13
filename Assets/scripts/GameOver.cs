using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true; ;
    }
    public void ClickYes()
    {
        SceneManager.LoadScene("Brunovsky");
    }
    public void ClickNo()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
