using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PromptShuffler : MonoBehaviour
{
    public string[] lines;

    public TextMeshProUGUI text;

    public TextMeshProUGUI abovetext;

    public GameObject PromptToggle;

    public PromptShuffler ResetCanvas;

    public void AccessPrompts()
    {
        PromptToggle.gameObject.SetActive(true);
    }

    public void ConfirmPrompt()
    {
        PromptToggle.gameObject.SetActive(false);
    }

    public void PromptShuffle()
    {
        string promptShow = lines[Random.Range(0, lines.Length)];
        text.text = promptShow;
        abovetext.text = promptShow;
    } 
}
