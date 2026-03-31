using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem4 : MonoBehaviour
{
    private static TooltipSystem4 current;

    public TooltipUI tooltip4;


    public void Awake()
    {
        current = this;
        current.tooltip4.gameObject.SetActive(false);
    }

    public static void Show(string content, string header = "")
    {
        if (current.tooltip4.gameObject.activeSelf == false)
        {
            current.tooltip4.gameObject.SetActive(true);
        }
        current.tooltip4.SetText(content, header);
    }

    public static void Hide()
    {
        if (current.tooltip4.gameObject.activeSelf == true)
        {
            current.tooltip4.gameObject.SetActive(false);
        }
    }
}
