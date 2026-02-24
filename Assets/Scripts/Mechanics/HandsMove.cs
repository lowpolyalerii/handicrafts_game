using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsMove : MonoBehaviour
{
    [SerializeField] float panSpeed;
    [SerializeField] float edgeSizeInPixels;  // How many pixels away from the edge of the screen the mouse can be before panning begins
    
    private Vector2 mousePos;
    private HandsMove handsmove;

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        
    }
}
