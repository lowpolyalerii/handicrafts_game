using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    private static TooltipSystem current;

    public TooltipUI tooltip;


    public void Awake()
    {
        current = this;
        current.tooltip.gameObject.SetActive(false);
    }

    public static void Show(string content, string header = "")
    {
        if (current.tooltip.gameObject.activeSelf == false)
        {
            current.tooltip.gameObject.SetActive(true);
            Debug.Log("Activated");
        }
        current.tooltip.SetText(content, header);
    }

    public static void Hide()
    {
        if (current.tooltip.gameObject.activeSelf == true)
        {
            current.tooltip.gameObject.SetActive(false);
            Debug.Log("WAAAAAAAAAAAA");
        }
    }
}
