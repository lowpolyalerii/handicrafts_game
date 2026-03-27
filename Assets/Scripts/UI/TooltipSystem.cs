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

    public static void Show()
    {
        current.tooltip.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        current.tooltip.gameObject.SetActive(false);
    }
}
