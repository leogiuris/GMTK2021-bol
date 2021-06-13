using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip slap, shake, bump, win, lose, stance1, stance2, pause, unpause, mumble1, mumble2, mumble3,
        mumble4, mumble5, mumble6, mumble7, mumble8, mumble9, mumble10, mumble11, winreact1, winreact2, winreact3,
        winreact4, losereact1, losereact2, losereact3, losereact4;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        slap = Resources.Load<AudioClip>("hand slap");
        shake = Resources.Load<AudioClip>("hand shake");
        bump = Resources.Load<AudioClip>("fist bump");
        win = Resources.Load<AudioClip>("win");
        lose = Resources.Load<AudioClip>("lose");
        stance1 = Resources.Load<AudioClip>("stance1");
        stance2 = Resources.Load<AudioClip>("stance2");
        pause = Resources.Load<AudioClip>("pause");
        unpause = Resources.Load<AudioClip>("unpause");
        mumble1 = Resources.Load<AudioClip>("mumble1");
        mumble2 = Resources.Load<AudioClip>("mumble2");
        mumble3 = Resources.Load<AudioClip>("mumble3");
        mumble4 = Resources.Load<AudioClip>("mumble4");
        mumble5 = Resources.Load<AudioClip>("mumble5");
        mumble6 = Resources.Load<AudioClip>("mumble6");
        mumble7 = Resources.Load<AudioClip>("mumble7");
        mumble8 = Resources.Load<AudioClip>("mumble8");
        mumble9 = Resources.Load<AudioClip>("mumble9");
        mumble10 = Resources.Load<AudioClip>("mumble10");
        mumble11 = Resources.Load<AudioClip>("mumble11");
        winreact1 = Resources.Load<AudioClip>("winreact1");
        winreact2 = Resources.Load<AudioClip>("winreact2");
        winreact3 = Resources.Load<AudioClip>("winreact3");
        winreact4 = Resources.Load<AudioClip>("winreact4");
        losereact1 = Resources.Load<AudioClip>("losereact1");
        losereact2 = Resources.Load<AudioClip>("losereact2");
        losereact3 = Resources.Load<AudioClip>("losereact3");
        losereact4 = Resources.Load<AudioClip>("losereact4");

        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
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
            case "stance1":
                audioSrc.PlayOneShot(stance1);
                break;
            case "stance2":
                audioSrc.PlayOneShot(stance2);   
                break;
            case "pause":
                audioSrc.PlayOneShot(pause);
                break;
            case "unpause":
                audioSrc.PlayOneShot(unpause);
                break;
            case "mumble1":
                audioSrc.PlayOneShot(mumble1);
                break;
            case "mumble2":
                audioSrc.PlayOneShot(mumble2);
                break;
            case "mumble3":
                audioSrc.PlayOneShot(mumble3);
                break;
            case "mumble4":
                audioSrc.PlayOneShot(mumble4);
                break;
            case "mumble5":
                audioSrc.PlayOneShot(mumble5);
                break;
            case "mumble6":
                audioSrc.PlayOneShot(mumble6);
                break;
            case "mumble7":
                audioSrc.PlayOneShot(mumble7);
                break;
            case "mumble8":
                audioSrc.PlayOneShot(mumble8);
                break;
            case "mumble9":
                audioSrc.PlayOneShot(mumble9);
                break;
            case "mumble10":
                audioSrc.PlayOneShot(mumble10);
                break;
            case "mumble11":
                audioSrc.PlayOneShot(mumble11);
                break;
            case "winreact1":
                audioSrc.PlayOneShot(winreact1);
                break;
            case "winreact2":
                audioSrc.PlayOneShot(winreact2);
                break;
            case "winreact3":
                audioSrc.PlayOneShot(winreact3);
                break;
            case "winreact4":
                audioSrc.PlayOneShot(winreact4);
                break;
            case "losereact1":
                audioSrc.PlayOneShot(losereact1);
                break;
            case "losereact2":
                audioSrc.PlayOneShot(losereact2);
                break;
            case "losereact3":
                audioSrc.PlayOneShot(losereact3);
                break;
            case "losereact4":
                audioSrc.PlayOneShot(losereact4);
                break;

        }

    }


}
