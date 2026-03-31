using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem3 : MonoBehaviour
{
    private static TooltipSystem3 current;

    public TooltipUI tooltip3;


    public void Awake()
    {
        current = this;
        current.tooltip3.gameObject.SetActive(false);
    }

    public static void Show(string content, string header = "")
    {
        if (current.tooltip3.gameObject.activeSelf == false)
        {
            current.tooltip3.gameObject.SetActive(true);
        }
        current.tooltip3.SetText(content, header);
    }

    public static void Hide()
    {
        if (current.tooltip3.gameObject.activeSelf == true)
        {
            current.tooltip3.gameObject.SetActive(false);
        }
    }
}
