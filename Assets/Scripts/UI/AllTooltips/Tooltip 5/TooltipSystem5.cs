using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem5 : MonoBehaviour
{
    private static TooltipSystem5 current;

    public TooltipUI tooltip5;


    public void Awake()
    {
        current = this;
        current.tooltip5.gameObject.SetActive(false);
    }

    public static void Show(string content, string header = "")
    {
        if (current.tooltip5.gameObject.activeSelf == false)
        {
            current.tooltip5.gameObject.SetActive(true);
        }
        current.tooltip5.SetText(content, header);
    }

    public static void Hide()
    {
        if (current.tooltip5.gameObject.activeSelf == true)
        {
            current.tooltip5.gameObject.SetActive(false);
        }
    }
}
