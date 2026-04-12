using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCollector : MonoBehaviour
{

    public int collected;
    public TextMeshProUGUI collectText;
    public bool isCounting = false;

    public bool ScissorsFound = false;
    public bool PaperFound = false;
    public bool PenFound = false;
    public bool HairtieFound = false;
    public bool PlushieFound = false;


    private void Start()
    {
        isCounting = false;
        collectText.enabled = false;
    }

    public void AddCount()
        {
            collectText.enabled = true;
            isCounting = true;
            collected++;
            collectText.text = "Objects Collected: " + collected.ToString() + "/5";
        }
}
