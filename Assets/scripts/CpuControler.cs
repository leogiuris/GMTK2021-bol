using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuControler : MonoBehaviour
{

    public float hSpeed = 0;
    public float speedMod = 0;
    public float ySpeed = 0;
    public float rotMod;
    private float rot;
    private float diff = 1;

    void Start()
    {
    }


    void Update()
    {
        Movement();
    }

    void FixedUpdate()
    {

        transform.position += new Vector3(hSpeed, 0, 0);
        rot -= ySpeed;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    private void Movement()
    {
        ySpeed = diff * rotMod;
        hSpeed = diff * speedMod;
    }
}