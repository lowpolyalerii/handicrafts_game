using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;
using static SoundManager;

public class UISoundTrigger : MonoBehaviour
{
    [Header("Types of Interaction")]
    [SerializeField] private SoundUI soundType = SoundUI.Unspecified;
    [SerializeField] private SoundTrigger playType = SoundTrigger.GetKeyDown;

    [Header("Manager")]
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private GameObject showing;

    private void Reset()
    {
        soundManager = FindFirstObjectByType<SoundManager>();
    }

    private void Start()
    {
        if (soundManager = null) {
            Debug.LogError("SoundManager has not been set. " +
                "Either search manually or click Reset while not in play mode.", this);
        }
    }

    public void PlaySound()
    {
       // soundManager.PlaySound(soundType, this);
    }

    public void OnMouseEnter()
    {
        if ((Input.GetKeyUp(KeyCode.E)) && showing == true)
        {
           // if (playType == SoundTrigger.GetKeyDown && soundManager != null)
               // soundManager.PlaySound(soundType, this);
        }
    }
}
