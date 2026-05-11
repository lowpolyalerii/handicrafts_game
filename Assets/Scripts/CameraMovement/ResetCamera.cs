using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ResetCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vcam;
    Vector3 CameraoriginalPos;
    Quaternion CamerainitialRotation;

    private void Start()
    {
        CameraoriginalPos = gameObject.transform.position;
        CamerainitialRotation = gameObject.transform.rotation;
    }

    public void ResetCameraPos()
    {
        vcam.transform.SetPositionAndRotation(CameraoriginalPos, CamerainitialRotation);
    }
}
