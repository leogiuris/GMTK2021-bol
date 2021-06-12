using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip slap, shake, bump, win, lose;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        slap = Resources.Load<AudioClip>("hand slap");
        shake = Resources.Load<AudioClip>("hand shake");
        bump = Resources.Load<AudioClip>("fist bump");
        win = Resources.Load<AudioClip>("win");
        lose = Resources.Load<AudioClip>("lose");

        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound("slap");
        }
    }
    public void PlaySound (string clip)
    {
        switch (clip)
        {
            case "slap":
                audioSrc.PlayOneShot(slap);
                break;
            case "shake":
                audioSrc.PlayOneShot(shake);
                break;
            case "bump":
                audioSrc.PlayOneShot(bump);
                break;
            case "win":
                audioSrc.PlayOneShot(win);
                break;
            case "lose":
                audioSrc.PlayOneShot(lose);
                break;
        }

    }


}
