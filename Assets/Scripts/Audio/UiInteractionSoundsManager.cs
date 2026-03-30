using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SoundManager;
using Object = UnityEngine.Object;

public class UiInteractionSoundsManager : MonoBehaviour
{
[Serializable]

public class SoundFeedback
    {
        public SoundUI soundType;
        public AudioClip soundClip;
    }

    [Header("Feedback List")]
    public List<SoundFeedback> soundFeedbacks = new List<SoundFeedback>();

    [Header("Audio Setup")]
    public AudioSource audioSource;

}
