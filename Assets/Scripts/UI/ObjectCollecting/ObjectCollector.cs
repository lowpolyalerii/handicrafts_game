using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCollector : MonoBehaviour
{

    public int collected;
    public TextMeshProUGUI collectText;
    public bool isCounting = false;

    private void Start()
    {
        isCounting = false;
    }

    public void AddCount()
    {
        isCounting = true;
        collected++;
        collectText.text = "Objects Collected: " + collected.ToString() + "/5";
    }
}
