using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BlurController : MonoBehaviour
{
    public Volume _blurVolume;
    public bool _blurActive;

    [SerializeField] private GameObject HTPObject;


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
        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.050f;

        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.150f;

        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.250f;
    }

    IEnumerator Grad2()
    {
        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.350f;

        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.450f;

        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.525f;
    }

    IEnumerator Grad3()
    {
        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.650f;

        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 0.850f;

        yield return new WaitForSeconds(0.05f);

        _blurVolume.weight = 1;

        HTPObject.gameObject.SetActive(false);
    }


    public void GradualBlur1()
    {
        StartCoroutine(Grad1());
    }

    public void GradualBlur2()
    {
        StartCoroutine(Grad2());
    }

    public void GradualBlur3()
    {
        StartCoroutine(Grad3());
    }
}
