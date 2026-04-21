using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BlurController : MonoBehaviour
{
    public Volume _blurVolume;
    public bool _blurActive;


    public void Start()
    {
        _blurVolume = GetComponent<Volume>();
        _blurActive = false;
        _blurVolume.weight = 0;
    }

    public void ToggleBlur()
    {
        _blurActive = !_blurActive; 

        if (_blurVolume.weight == 0)
        {
            _blurVolume.weight = 1;
        }
        else
        {
            _blurVolume.weight = 0;
        }

        //_blurVolume.weight = _blurActive ? 1 : 0;
    }
}
