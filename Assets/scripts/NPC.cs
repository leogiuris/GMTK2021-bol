using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
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
    

    //slide in and out;
    public Transform spawn;
    public Transform deSpawn;

    void Start()
    {
        bodyRen = body.gameObject.GetComponent<SpriteRenderer>();
        faceRen = face.gameObject.GetComponent<SpriteRenderer>();
        ChangeNpc();
        body.transform.position = spawn.transform.position;
        
    }


    void Update()
    {
        
    }
    public void ChangeNpc()
    {
        bodyRen.sprite = bodies[Random.Range(0, bodies.Count)];
        faceRen.sprite = faces[Random.Range(0, faces.Count)];
        npcChange = bodies.IndexOf(bodyRen.sprite);
        npcSpeed = faces.IndexOf(faceRen.sprite);

    }
}
