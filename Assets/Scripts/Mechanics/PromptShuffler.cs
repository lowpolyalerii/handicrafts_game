using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using FreeDraw;

public class PromptShuffler : MonoBehaviour
{
    public string[] lines;

    public TextMeshProUGUI text;

    public TextMeshProUGUI abovetext;

    public GameObject PromptToggle;

    public Drawable ResetCanvasOnContinue;

    public AudioSource AudioSource;

    public void AccessPrompts()
    {
        PromptToggle.gameObject.SetActive(true);
    }

    public void ConfirmPrompt()
    {
        PromptToggle.gameObject.SetActive(false);
        ResetCanvasOnContinue.ResetCanvas();
        AudioSource.Play();
    }

    public void PromptShuffle()
    {
        string promptShow = lines[Random.Range(0, lines.Length)];
        text.text = promptShow;
        abovetext.text = promptShow;
    } 
}
