using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GradualBlurController : MonoBehaviour
{
    public Volume _blurVolume;

    public void Start()
    {
        _blurVolume = GetComponent<Volume>();
        _blurVolume.weight = 0.14f;
    }

    IEnumerator GradBlur()
    {
        _blurVolume.weight = Random.Range(0.14f, 0.5f);

        yield return new WaitForSeconds(100f);
    }

    private void Update()
    {
        StartCoroutine(GradBlur());
    }
}
