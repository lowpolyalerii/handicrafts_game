using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BlurController : MonoBehaviour
{
    private Volume _blurVolume;
    public bool _blurActive;


    void Start()
    {
        _blurVolume = GetComponent<Volume>();
        _blurActive = false;
        _blurVolume.weight = 0;
    }

    public void ToggleBlur()
    {
        _blurActive = !_blurActive; 
        _blurVolume.weight = _blurActive ? 1 : 0;
    }
}
