using UnityEngine;
using UnityEngine.UIElements;

using System.Collections;
using System.Collections.Generic;


public class Player : MonoBehaviour
{

    public float hSpeed = 1;
    public float hDir;
    public float ySpeed = 1;
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
        
        transform.position += new Vector3(hSpeed* hDir,0,0);
        rot += ySpeed * -yDir;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    private void PlayerInput()
    {
        hDir = (Input.GetAxis("Mouse X"));
        yDir = (Input.GetAxis("Mouse Y"));
    }
}
