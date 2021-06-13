using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class RandomSounds : MonoBehaviour
    {
        public string currentClip;
        public AudioSource source;
        public float minWaitBetweenPlays = 1f;
        public float maxWaitBetweenPlays = 10f;
        public float waitTimeCountdown = -1f;
        public List<string> audioClips;

        void Start()
        {  
            source = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (!source.isPlaying)
            {
                if (waitTimeCountdown < 0f)
                {
                    currentClip = audioClips[Random.Range(0, audioClips.Count)];
                    SoundManagerScript.PlaySound(currentClip);
                    waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
                }
                else
                {
                    waitTimeCountdown -= Time.deltaTime;
                }
            }
        }
    }

