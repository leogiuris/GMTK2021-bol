using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public class RandomSounds : MonoBehaviour
    {
        public List<AudioClip> audioClips;
        public AudioClip currentClip;
        public AudioSource source;
        public float minWaitBetweenPlays = 30f;
        public float maxWaitBetweenPlays = 1200f;
        public float waitTimeCountdown = -1f;

        void Start()
        {
            List<string> backgroundsounds = new List<string>
            source = GetComponent<AudioSource>();

            backgroundsounds.Add(new BackgroundSound("OpenBeer", 1));
            backgroundsounds.Add(new BackgroundSound("Clink", 2));
        }

        void Update()
        {
            if (!source.isPlaying)
            {
                if (waitTimeCountdown < 0f)
                {
                    currentClip = audioClips[Random.Range(0, audioClips.Count)];
                    source.clip = currentClip;
                    source.Play();
                    waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
                }
                else
                {
                    waitTimeCountdown -= Time.deltaTime;
                }
            }
        }
    }




}
