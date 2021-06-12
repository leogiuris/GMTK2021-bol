using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip slap, shake, bump, win, lose ; 
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        slap = Resources.Load<AudioClip>("hand slap");
        shake = Resources.Load<AudioClip>("hand shake");
        bump = Resources.Load<AudioClip>("fist bump");
        win = Resources.Load<AudioClip>("win");
        lose = Resources.Load<AudioClip>("lose");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip){
            case "slap":
                audioSrc.PlayOneShot(slap);
            case "shake":
                audioSrc.PlayOneShot(shake);
            case "bump":
                audioSrc.PlayOneShot(slap);
            case "win":
                audioSrc.PlayOneShot(slap);
            case "lose":
                audioSrc.PlayOneShot(slap);
                break;
        }

    }


}
