using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayWorldBlur : MonoBehaviour
{
    public AudioSource source;
    public float minWaitBetweenBlurs = 1f;
    public float maxWaitBetweenBlurs = 5f;
    public float waitTimeCountdown = -1f;
     
    void Start()
    {
        BlurController blurController = GetComponent<BlurController>();
    }

    void Update()
    {
        if (!source.isPlaying)
        {
            if (waitTimeCountdown < 0f)
            {
                //currentClip = audioClips[Random.Range(0, audioClips.Count)];
                //source.clip = currentClip;
                source.Play();
                waitTimeCountdown = Random.Range(minWaitBetweenBlurs, maxWaitBetweenBlurs);
            }
            else
            {
                waitTimeCountdown -= Time.deltaTime;
            }
        }
    }
}
