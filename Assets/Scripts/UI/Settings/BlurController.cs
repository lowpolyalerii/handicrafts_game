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

    IEnumerator Grad1()
    {
        yield return new WaitForSeconds(0.2f);

        _blurVolume.weight = 0.150f;

        yield return new WaitForSeconds(0.2f);

        _blurVolume.weight = 0.250f;

        yield return new WaitForSeconds(0.2f);

        _blurVolume.weight = 0.325f;
    }


    public void GradualBlur1()
    {
        StartCoroutine(Grad1());
    }

    public void GradualBlur2()
    {
        _blurVolume.weight = 0.500f;
    }

    public void GradualBlur3()
    {
        _blurVolume.weight = 0.750f;
    }
}
