using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject toggle;
    [SerializeField] string [] lines;
    [SerializeField] TextMeshProUGUI text;
    public GameObject arrows;

    Vector3 CameraoriginalPos;
    Quaternion CamerainitialRotation;

    private void Start()
    {
        CameraoriginalPos = gameObject.transform.position;
        CamerainitialRotation = gameObject.transform.rotation;
    }

    public void AccessHTP()
    {
        toggle.gameObject.SetActive(true);
        arrows.gameObject.SetActive(true);
    }

    public void DisplayNextLine()
    {
        string promptShow = lines[Random.Range(0, lines.Length)];
        text.text = promptShow;
    }

    public void Continue()
    {
        toggle.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
    }

    public void ResetCamPos()
    {
        transform.position = CameraoriginalPos;
        transform.rotation = CamerainitialRotation;
    }
}
