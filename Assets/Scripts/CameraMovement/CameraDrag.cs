using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraDrag : MonoBehaviour
{
    private Vector3 _origin;
    private Vector3 _difference;

    private Camera _mainCamera;

    private bool _isDragging;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void OnDrag(InputAction.CallbackContext ctx) // sets the value of dragging whether the mouse button is being held or not
    {
        if (ctx.started) _origin = GetMousePosition;
        _isDragging = ctx.started || ctx.performed;
    }

    private void LateUpdate()
    {
        if (!_isDragging) return; //check if dragging or return

        _difference = GetMousePosition - transform.position;
        transform.position = _origin - _difference;
    }

    private Vector3 GetMousePosition =>
        _mainCamera.ScreenToWorldPoint((Vector3)Mouse.current.position.ReadValue());
}
