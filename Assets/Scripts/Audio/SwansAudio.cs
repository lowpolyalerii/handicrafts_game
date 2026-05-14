using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class SwansAudio : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioClip currentClip;
    public AudioSource source;

    void OnMouseEnter()
    {
        currentClip = audioClips[Random.Range(0, audioClips.Count)];
        source.clip = currentClip;
        source.Play();

    }
}
