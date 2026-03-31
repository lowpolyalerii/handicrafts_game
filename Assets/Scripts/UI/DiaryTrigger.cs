using UnityEngine;
using UnityEngine.UI;

public class DiaryTrigger : MonoBehaviour
{

    public Canvas canvas;

    void Start()
    {
        // Turns the image off.
        canvas.enabled = false;
    }

    void OnMouseDown()
    {
        // Turns the image on if it is off, and off if it is on.
        canvas.enabled = !canvas.enabled;
    }
}