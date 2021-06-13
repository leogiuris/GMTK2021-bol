using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgPlayer : MonoBehaviour
{
    private GameController controller;
    public AudioSource source;
    public List<AudioClip> songs;
    private int track;

    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Update()
    {

        if (!GameController.isPaused)
        {
            if (controller.dialogue)
            {
                track = 0;
            }
            else
            {
                track = 1;
            }
        }
        else
        {
            track = 2;
        }
        Switch();
    }

    private void Switch()
    {
        if(track != songs.IndexOf(source.clip))
        {
            source.clip = songs[track];
            source.Play();

        }
    }
}
