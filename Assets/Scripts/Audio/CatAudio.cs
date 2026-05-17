using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAudio : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioClip currentClip;
    public AudioSource source;
    public float minWaitBetweenPlays = 0.1f;
    public float maxWaitBetweenPlays = 0.3f;
    public float waitTimeCountdown = 0.1f;

    [SerializeField] private CatTrigger catTrigger1;
    [SerializeField] private CatTrigger catTrigger2;
    [SerializeField] private CatTrigger catTrigger3;



    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (catTrigger1.trigger == true || catTrigger2.trigger == true || catTrigger3.trigger == true)
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
