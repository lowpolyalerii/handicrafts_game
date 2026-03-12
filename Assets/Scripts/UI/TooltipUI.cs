using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class TooltipUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private ObjectUIHover Object;
    public bool trigger;

    private void Update()
    {
        if ((Input.GetKeyUp(KeyCode.E)) && Object.trigger == true)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    public void Show()
    {
        containerGameObject.SetActive(true);
    }

    public void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
