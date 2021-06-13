using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuControler : MonoBehaviour
{
    public Hand hand;
    public NPC npc;
    public float countDown = -1f;

    //movement
    public float hSpeed = 0;
    public float ySpeed = 0;
    private float rot;
    private float diff = 1;

    void Start()
    {
        
       
    }


    void Update()
    {
        Movement();
        //reduzir timer
        countDown -= Time.deltaTime;

    }

    void FixedUpdate()
    {      
    }

    private void Movement()
    {
        //formula movimento
        ySpeed = diff ;
        hSpeed = diff * npc.npcSpeed;
        //formula trocamão
        if(countDown<0)
        {
            hand.ChangeHandMode();
            countDown = npc.npcChange * diff;
        }

        //Movimento
        if (transform.position.x < -4)
        {
            transform.position += new Vector3(hSpeed * Time.deltaTime, 0, 0) ;

            rot -= ySpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, rot);
        }

    }

}