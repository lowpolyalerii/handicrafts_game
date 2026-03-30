using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem2 : MonoBehaviour
{
    private static TooltipSystem2 current;

    public TooltipUI tooltip2;


    public void Awake()
    {
        current = this;
        current.tooltip2.gameObject.SetActive(false);
    }

    public static void Show(string content, string header = "")
    {
        if (current.tooltip2.gameObject.activeSelf == false)
        {
            current.tooltip2.gameObject.SetActive(true);
            Debug.Log("Activated2");
        }
        current.tooltip2.SetText(content, header);
    }

    public static void Hide()
    {
        if (current.tooltip2.gameObject.activeSelf == true)
        {
            current.tooltip2.gameObject.SetActive(false);
            Debug.Log("WIIIIII");
        }
    }
}
