using UnityEngine;
using UnityEngine.UIElements;

using System.Collections;
using System.Collections.Generic;


public class Player : MonoBehaviour
{
    public Hand hand;

    public float hSpeed = 1;
    public float hDir;
    public float ySpeed = 0.5f;
    public float yDir;
    private float rot;
    public Transform t_init;
    public Vector3 mouse_init;
    
    

    void Start()
    {
        mouse_init = Input.mousePosition;
        
        rot = 20;
    }

    
    public void ResetMouse()
    {
        mouse_init = Input.mousePosition;
    }

    void Update()
    {
        PlayerInput();
    }

    void FixedUpdate()
    {
        
        transform.position = t_init.position + (Input.mousePosition / 100) - (mouse_init/100);
    }

    

    private void PlayerInput()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!GameController.Instance.dialogue && !GameController.isPaused)
                hand.ChangeHandMode();
        }
    }
}
