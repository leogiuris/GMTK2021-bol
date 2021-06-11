using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuControler : MonoBehaviour
{
    public float hSpeed = 1;
    public float speedMod = 1;
    public float ySpeed = 1;
    public float rotMod;
    public float yDir;
    private float rot;
    private float diff =1; 
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
        rot += ySpeed;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    private void Movement()
    {
        hSpeed = diff * speedMod;
        ySpeed = diff * rotMod;
    }
}
