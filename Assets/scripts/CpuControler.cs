using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuControler : MonoBehaviour
{
    public Hand hand;
    public GameController gameCon;
    //apearance
    public List<Sprite> bodies;
    public List<Sprite> faces;
    public GameObject body;
    public GameObject face;
    private SpriteRenderer bodyRen;
    private SpriteRenderer faceRen;
    //NPC modifiers
    public float npcSpeed;
    public float npcChange;

    //timer
    public float countDown = -1f;

    //slide in and out;
    public Transform spawn;
    public Transform deSpawn;


    //movement
    public float hSpeed = 0;
    public float ySpeed = 0;
    private float rot;
    private float diff = 1;

    void Start()
    {
        bodyRen = body.gameObject.GetComponent<SpriteRenderer>();
        faceRen = face.gameObject.GetComponent<SpriteRenderer>();

        body.transform.position = spawn.transform.position;
        ChangeNpc();
        Cursor.visible = false;
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
        hSpeed = diff * npcSpeed;
        //formula trocamão
        if(countDown<0)
        {
            hand.ChangeHandMode();
            countDown = npcChange * diff;
        }

        //Movimento
        if (transform.position.x < -4)
        {
            transform.position += new Vector3(hSpeed * Time.deltaTime, 0, 0) ;

            rot -= ySpeed;
            transform.rotation = Quaternion.Euler(0, 0, rot * Time.deltaTime);
        }

    }

    private void ChangeNpc()
    {
        bodyRen.sprite = bodies[Random.Range(0, bodies.Count)];
        faceRen.sprite = faces[Random.Range(0, faces.Count)];
        npcChange = bodies.IndexOf(bodyRen.sprite);
        npcSpeed = faces.IndexOf(faceRen.sprite);

    }

}