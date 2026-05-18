using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject toggle;
    [SerializeField] string [] lines;
    [SerializeField] TextMeshProUGUI text;
    public GameObject arrows;
    public int index = 0;

    public void AccessHTP()
    {
        toggle.gameObject.SetActive(true);
    }

    public void DisplayNextLine()
    {

        index += 1;

        if (index == lines.Length)
        {
            index = 0;

            if (index == 2 & index == 3)
            {
                arrows.gameObject.SetActive(true);
            }
            else
            {
                arrows.gameObject.SetActive(false);
            }
        }


        string promptShow = lines[index];
        text.text = promptShow;

    }

    public void Continue()
    {
        toggle.gameObject.SetActive(false);
        arrows.gameObject.SetActive(false);
    }
}
