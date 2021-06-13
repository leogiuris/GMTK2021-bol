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

    

    void Start()
    {
        rot = 20;
    }

    

    void Update()
    {
        PlayerInput();
    }

    void FixedUpdate()
    {

        transform.position = Input.mousePosition / 100;
    }

    

    private void PlayerInput()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!GameController.Instance.dialogue)
                hand.ChangeHandMode();
        }
    }
}
