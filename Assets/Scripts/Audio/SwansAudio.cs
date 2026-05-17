using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class SwansAudio : MonoBehaviour
{
    public List<AudioClip> audioClips;
    public AudioClip currentClip;
    public AudioSource source;

    //public GameObject[] Swans;

    [SerializeField] bool trigger = false;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnMouseEnter()
    {
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                trigger = true;
            }
        }

        if (trigger == true)
        {
            currentClip = audioClips[Random.Range(0, audioClips.Count)];
            source.clip = currentClip;
            source.Play();
        }
    }

    public void OnMouseExit()
    {
        trigger = false;
    }

}

